namespace api.Services
{
    public class LotCreateInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceStart { get; set; }
        public int Hours { get; set; }
        public IFormFile FormFile { get; set; }
    }
}
