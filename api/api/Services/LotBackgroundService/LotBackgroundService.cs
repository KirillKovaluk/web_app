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

        }
    }
}
