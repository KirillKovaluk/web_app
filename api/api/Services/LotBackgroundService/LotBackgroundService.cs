using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class LotBackgroundService : ILotBackgroundService
    {
        private readonly Context _context;

        public LotBackgroundService(
            Context context)
        {
            _context = context;
        }
        public async Task CloseLotBackgroundAsync()
        {
            var lots = await _context.Lots
                .Include(x => x.UserCreated)
                .Include(x => x.UserBet)
                .Where(x => x.LotStatus == LotStatus.ACTIVE && x.DateEnd < DateTime.UtcNow)
                .ToListAsync();

            foreach (var lot in lots)
            {
                if (lot.PriceBet.HasValue)
                {
                    lot.UserBoughtId = lot.UserBetId;
                    lot.UserBet.Balance -= lot.PriceBet.Value;
                    lot.UserCreated.Balance += lot.PriceBet.Value;
                }
                // Close past time
                lot.LotStatus = LotStatus.CLOSED;

                await _context.SaveChangesAsync();
            }
        }
    }
}
