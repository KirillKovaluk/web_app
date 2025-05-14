using api.Models;

namespace api.Services
{
    public class LotView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceStart { get; set; }
        public decimal? PriceResult { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int Hours { get; set; }
        public LotStatus LotStatus { get; set; }
        public LotType LotType { get; set; }

        public int UserCreatedId { get; set; }
        public UserView UserCreated { get; set; }

        public int? UserBoughtId { get; set; }
        public UserView UserBought { get; set; }
    }

    public static class LotViewExtension
    {
        public static LotView ToView(this Lot lot)
        {
            var lotView = new LotView
            {
                Id = lot.Id,
                Name = lot.Name,
                Description = lot.Description,
                PriceStart = lot.PriceStart,
                PriceResult = lot.PriceResult,
                DateStart = lot.DateStart,
                DateEnd = lot.DateEnd,
                Hours = lot.Hours,
                LotStatus = lot.LotStatus,
                LotType = lot.LotType,

                UserCreatedId = lot.UserCreatedId,
                UserBoughtId = lot.UserBoughtId
            };

            lotView.UserCreated = lot.UserCreated.ToView();

            if (lot.UserBought != null)
            {
                lotView.UserBought = lot.UserBought.ToView();
            }

            return lotView;
        }
    }
}
