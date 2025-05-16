using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class LotService : ILotService
    {
        private readonly IErrorService _errorService;
        private readonly Context _context;

        public LotService(
            IErrorService errorService,
            Context context) 
        {
            _errorService = errorService;
            _context = context;
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
    }
}
