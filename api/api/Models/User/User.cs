namespace api.Models
{
    public class User
    {
        public User() 
        {
            LotsCreated = new HashSet<Lot>();
            LotsBought = new HashSet<Lot>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public decimal Balance { get; set; }

        public ICollection<Lot> LotsCreated { get; set; }
        public ICollection<Lot> LotsBought { get; set; }
    }
}
