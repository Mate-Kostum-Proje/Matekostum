using System.ComponentModel.DataAnnotations;
using Mate.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mate.MVC.Areas.Admin.Models_VMs
{
    public class ProductEditAdminVM
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Ürün İsmi Zorunludur")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string ProductName { get; set; }


        [MaxLength(200, ErrorMessage = "En fazla 200 karakter olmalıdır")]
        public string? Description { get; set; }


        [Required(ErrorMessage = "Yaş Grubu Zorunludur")]
        public bool? IsAdult { get; set; }


        [Range(0, 100000, ErrorMessage = "Satış Fiyatı 0-100000 arasında olmalıdır.")]
        public int? UnitPriceForSale { get; set; }


        [Range(0, 100000, ErrorMessage = "kiralama Fiyatı 0-100000 arasında olmalıdır")]
        public int UnitPriceForRent { get; set; }

        public bool IsSale { get; set; }
        public bool? Gender { get; set; }

        public string? ProductCategoryId { get; set; }
        public string? ProductRegionId { get; set; }
        public string? ProductSubRegionId { get; set; }

        public List<Size> AllSizes { get; set; } = new List<Size>();



        // Kullanıcının seçtiği bedenler ve miktarları

        public List<SelectedSizeVM> SelectedSizes { get; set; } = new List<SelectedSizeVM>();

        [BindNever]
        public List<ProductCategory>? Categories { get; set; }
        [BindNever]
        public List<ProductRegion>? Regions { get; set; }
        [BindNever]
        public List<ProductSubRegion>? SubRegions { get; set; }

        public List<SelectListItem> CategorySelectList => Categories?.Select(c => new SelectListItem
        {
            Value = c.Id,
            Text = c.Name
        }).ToList() ?? new List<SelectListItem>();

        public List<SelectListItem> RegionSelectList => Regions?.Select(r => new SelectListItem
        {
            Value = r.Id,
            Text = r.Name
        }).ToList() ?? new List<SelectListItem>();

        public List<SelectListItem> SubRegionSelectList => SubRegions?.Select(sr => new SelectListItem
        {
            Value = sr.Id,
            Text = sr.Name
        }).ToList() ?? new List<SelectListItem>();

        [Required(ErrorMessage = "Ürün Kategorisi Seçmek Zorunludur")]
        public string? SelectedCategoryId { get; set; }
        public string? SelectedRegionId { get; set; }
        public string? SelectedSubRegionId { get; set; }



        public IFormFile? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
