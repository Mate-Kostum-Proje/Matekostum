namespace Mate.MVC.Models.VMs
{
    public class BasketDetailVM
    {
        public string BasketDetailId { get; set; } // Sepet Detay ID
        public string ProductId { get; set; } // Ürün ID
        public string ProductName { get; set; } // Ürün adı
        public decimal Price { get; set; } // Ürün fiyatı
        public int Amount { get; set; } // Miktar
        public int Size { get; set; }
        public decimal TotalPrice { get; set; } // Toplam fiyat
    }
}
