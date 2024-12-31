using System.ComponentModel.DataAnnotations;

namespace Mate.MVC.Areas.Admin.Models_VMs
{
    public class SelectedSizeVM
    {
        public string SizeId { get; set; }

        [Required(ErrorMessage = "Beden seçimi zorunludur.")]
        public int SizeNumber { get; set; }
        [Required(ErrorMessage = "Miktar zorunludur.")]
        [Range(1, 20, ErrorMessage = "Miktar 1 ile 20 arasında olmalıdır.")]
        public int SizeAmount { get; set; }
    }
}
