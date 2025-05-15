namespace api.Models
{
    public class FileImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public FileImageType Type { get; set; }

        public int? LotId { get; set; }
        public Lot Lot { get; set; }
    }
}
