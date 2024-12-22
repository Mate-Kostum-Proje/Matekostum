using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class BasketDetail : BaseEntity
    {
        public Basket Baskets { get; set; }
        public string BasketId { get; set; }
        public Product Products { get; set; }
        public string ProductId { get; set; }
        public int? UnitPriceForSale { get; set; }
        public int UnitPiceForRent { get; set; }
        public int ProductSize { get; set; }
        public int Amount { get; set; }
        public bool IsSale { get; set; }

    }
}
