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

        public async Task<IEnumerable<LotView>> GetLotsPublicAsync()
        {
            var lots = await _context.Lots
                .Include(x => x.UserCreated)
                .Include(x => x.UserBought)
                .ToListAsync();

            List<LotView> lotsView = new List<LotView>();

            foreach (var lot in lots)
            {
                LotView lotView = lot.ToView();
                lotsView.Add(lotView);
            }

            //return lots.Select(lot => lot.ToView());

            return lotsView;
        }
    }
}
