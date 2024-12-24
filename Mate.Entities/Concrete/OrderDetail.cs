using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        public Order Orders { get; set; }
        public string OrderId { get; set; }
        public Product Products { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public OrderSituation? OrderSituations { get; set; }
        public string? SituationId { get; set; }
        public string SituationName { get; set; }
        public bool IsSale { get; set; }
        public int? UnitPriceForSale { get; set; }
        public int? UnitPiceForRent { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductSize { get; set; }
        public int Amount { get; set; }

    }
}
