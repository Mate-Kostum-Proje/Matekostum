using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public bool? IsAdult { get; set; } //Not Sure
        public int Size { get; set; }
        public int? UnitPriceForSale { get; set; }
        public int UnitPiceForRent { get; set; }

        //resim işi TODO
        public List<BasketDetail>? BasketDetails { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }

        public ProductCategory ProductCategories { get; set; }
        public string ProductCategoryId { get; set; }
        public ProductRegion ProductRegions { get; set; }
        public string ProductRegionId { get; set; }

    }
}
