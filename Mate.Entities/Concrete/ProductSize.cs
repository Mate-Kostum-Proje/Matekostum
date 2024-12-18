using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class ProductSize : BaseEntity
    {
        public Product Products { get; set; }
        public string ProductId { get; set; }
        public Size Sizes { get; set; }
        public string SizeId { get; set; }
        public string ProductPhotoPath { get; set; }
        public int SizeNumber { get; set; }
        public int SizeAmount { get; set; }
    }
}
