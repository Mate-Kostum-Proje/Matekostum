namespace Mate.MVC.Areas.Admin.Models_VMs
{
    public class ProductAdminVM
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public bool? IsAdult { get; set; }
        public List<(int SizeNumber, int SizeAmount)> SizesWithAmounts { get; set; } // Beden ve Sayı Eşleştirmesi
        public int? UnitPriceForSale { get; set; }
        public int UnitPriceForRent { get; set; }
        public bool IsSale { get; set; }
        public bool? Gender { get; set; }
        public string? PhotoPath { get; set; }
        public string CategoryName { get; set; }
        public string? RegionName { get; set; }
        public string? SubRegionName { get; set; }

    }
}
