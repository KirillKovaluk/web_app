namespace api.Models
{
    public class Lot
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
        public User UserCreated { get; set; }

        public int? UserBoughtId { get; set; }
        public User UserBought { get; set; }
    }
}
