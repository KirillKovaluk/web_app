using api.Models;

namespace api.Services
{
    public class LotUserView
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
        public string LotType { get; set; }

        public IEnumerable<FileImageView> FileImages { get; set; }

        public int UserCreatedId { get; set; }
        public UserPublicView UserCreated { get; set; }

        public int? UserBoughtId { get; set; }
        public UserPublicView UserBought { get; set; }
    }

    public static class LotUserViewExtension
    {
        public static LotUserView ToUserView(this Lot lot)
        {
            var lotView = new LotUserView
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
                LotType = lot.LotType.ToString("G"),

                UserCreatedId = lot.UserCreatedId,
                UserBoughtId = lot.UserBoughtId,
                
            };

            if ( lot.FileImages.Any()) 
            {
                lotView.FileImages = lot.FileImages.Select(x => x.ToView());
            }

            if (lot.UserCreated != null)
            {
                lotView.UserCreated = lot.UserCreated.ToPublicView();
            }

            if (lot.UserBought != null)
            {
                lotView.UserBought = lot.UserBought.ToPublicView();
            }

            return lotView;
        }
    }
}
