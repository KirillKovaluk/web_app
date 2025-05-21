using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Models;
using System.IO;

namespace api.Services
{
    public class LotService : ILotService
    {
        private readonly IErrorService _errorService;
        private readonly Context _context;
        private readonly IUserContext _userContext;

        private readonly string _contentRootPath;

        private const string Slash = "/";
        private const string StaticRootFolder = "/wwwroot";
        private const string FolderImages = "/images";


        public LotService(
            IErrorService errorService,
            Context context,
            IUserContext userContext,
            IWebHostEnvironment webHostEnvironment) 
        {
            _errorService = errorService;
            _context = context;
            _userContext = userContext;
            _contentRootPath = webHostEnvironment.ContentRootPath;
        }

        public async Task<IEnumerable<LotPublicView>> GetLotsPublicAsync()
        {
            var lots = await _context.Lots
                .AsNoTracking()
                .Include(x => x.UserCreated)
                .Where(x => x.LotStatus == LotStatus.ACTIVE)
                .OrderByDescending(x => x.DateCreated)
                .ToListAsync();

            List<LotPublicView> lotsView = new List<LotPublicView>();

            foreach (var lot in lots)
            {
                LotPublicView lotView = lot.ToView();
                lotsView.Add(lotView);
            }

            //return lots.Select(lot => lot.ToView());

            return lotsView;
        }

        public async Task<IEnumerable<LotUserView>> GetLotsCreatedAsync()
        {
            var lots = await _context.Lots
                .AsNoTracking()
                .Include(x => x.UserCreated)
                .Include(x => x.UserBought)
                .Where(x => x.UserCreated.Id == _userContext.UserId)
                .OrderByDescending(x => x.DateCreated)
                .ToListAsync();

            return lots.Select(lot => lot.ToUserView());
        }
        public async Task<IEnumerable<LotUserView>> GetLotsBoughtAsync()
        {
            var lots = await _context.Lots
                .AsNoTracking()
                .Include(x => x.UserCreated)
                .Include(x => x.UserBought)
                .Where(x => x.UserBought.Id == _userContext.UserId)
                .OrderByDescending(x => x.DateCreated)
                .ToListAsync();

            return lots.Select(lot => lot.ToUserView());
        }

        public async Task CreateLotAsync(LotCreateInput lotCreateInput)
        {
            if (string.IsNullOrEmpty(lotCreateInput.Name)
                || string.IsNullOrEmpty(lotCreateInput.Description)
                || lotCreateInput.FormFile == null)
            {
                _errorService.Add(ErrorCode.MODEL_IS_INVALID);
                return;
            }

            var lot = new Lot
            {
                Name = lotCreateInput.Name,
                Description = lotCreateInput.Description,
                Hours = lotCreateInput.Hours,
                PriceStart = lotCreateInput.PriceStart,
                UserCreatedId = _userContext.UserId,
                DateCreated = DateTime.UtcNow,
                DateStart = DateTime.UtcNow,
                DateEnd = DateTime.UtcNow.AddHours(lotCreateInput.Hours),
                LotStatus = LotStatus.ACTIVE,
            };

            _context.Lots.Add(lot);

            var file = new FileImage
            {
                Name = lotCreateInput.Name,
                Created = DateTime.UtcNow,
                Type = FileImageType.IMAGE,
                Lot = lot,
            };

            // save file
            var baseFolder = _contentRootPath + StaticRootFolder;

            if (!Directory.Exists(baseFolder))
            {
                Directory.CreateDirectory(baseFolder);
            }

            string guid = Guid.NewGuid().ToString();
            string fileName = lotCreateInput.FormFile.FileName;
            string fileType = fileName.Substring(fileName.LastIndexOf("."));

            file.Guid = guid;

            var path = baseFolder + FolderImages + Slash + guid + fileType;

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await lotCreateInput.FormFile.CopyToAsync(fileStream);
            }

            file.Path = path.Replace(baseFolder, string.Empty);

            // ===

            _context.FileImages.Add(file);

            await _context.SaveChangesAsync();
        }
        public async Task BetLotAsync(LotBetInput lotBetInput)
        {
            var lot = await _context.Lots
                .Include(x => x.UserCreated)
                .FirstOrDefaultAsync(x => x.Id == lotBetInput.Id && x.LotStatus == LotStatus.ACTIVE);

            if (lot == null)
            {
                _errorService.Add(ErrorCode.DATA_NOT_FOUND);
                return;
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Id == _userContext.UserId);

            if (user == null)
            {
                _errorService.Add(ErrorCode.USER_NOT_FOUND);
                return;
            }

            if (lot.UserCreated.Id == user.Id)
            {
                _errorService.Add(ErrorCode.ACTION_IS_INVALID);
                return;
            }

            if (!lot.PriceBet.HasValue)
            {
                lot.PriceBet = lot.PriceStart;
            }
            else
            {
                lot.PriceBet += 5;
            }

            if (user.Balance < lot.PriceBet)
            {
                _errorService.Add(ErrorCode.NO_MONEY_FOR_BET);
                return;
            }

            lot.UserBetId = user.Id;

            await _context.SaveChangesAsync();
        }
    }
}
