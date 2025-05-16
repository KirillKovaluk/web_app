using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class LotService : ILotService
    {
        private readonly IErrorService _errorService;
        private readonly Context _context;
        private readonly IUserContext _userContext;

        public LotService(
            IErrorService errorService,
            Context context,
            IUserContext userContext) 
        {
            _errorService = errorService;
            _context = context;
            _userContext = userContext;
        }

        public async Task<IEnumerable<LotPublicView>> GetLotsPublicAsync()
        {
            var lots = await _context.Lots
                .Include(x => x.UserCreated)
                .Where(x => x.LotStatus == LotStatus.ACTIVE)
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
                .Include(x => x.UserCreated)
                .Include(x => x.UserBought)
                .Where(x => x.UserCreated.Id == _userContext.UserId)
                .ToListAsync();

            return lots.Select(lot => lot.ToUserView());
        }
        public async Task<IEnumerable<LotUserView>> GetLotsBoughtAsync()
        {
            var lots = await _context.Lots
                .Include(x => x.UserCreated)
                .Include(x => x.UserBought)
                .Where(x => x.UserBought.Id == _userContext.UserId)
                .ToListAsync();

            return lots.Select(lot => lot.ToUserView());
        }
    }
}
