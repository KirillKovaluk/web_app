using api.Models;

namespace api.Services
{
    public class FileImageView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public DateTime Created { get; set; }
        public FileImageType Type { get; set; }

        public int? LotId { get; set; }
    }

    public static class FileImageViewExtension
    {
        public static FileImageView ToView(this FileImage fileImage)
        {
            var fileImageView = new FileImageView
            {
                Id = fileImage.Id,
                Name = fileImage.Name,
                Guid = fileImage.Guid,
                Path = fileImage.Path,
                Created = fileImage.Created,
                Type = fileImage.Type,
                LotId = fileImage.LotId,
            };

            return fileImageView;
        }
    }
}
