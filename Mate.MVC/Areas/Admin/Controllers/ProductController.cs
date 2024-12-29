using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Areas.Admin.Models_VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Mate.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController(IManager<Product> productManager
                            , IManager<ProductCategory> productCategoryManager
                            , IManager<ProductRegion> productRegionManager
                            , IManager<ProductSubRegion> productSubRegionManager
                            , IManager<Size> sizeManager
                            , IManager<ProductSize> productSizeManager
                            , INotyfService notyfService
                            , IMapper mapper
                            , IHostEnvironment hostEnvironment) : Controller
    {
        public IActionResult Index()
        {
            var products = productManager.GetAll().ToList();
            return View(products);
        }
        [Authorize]
        public IActionResult KiralıkBindallıIndex()
        {
            var products = productManager.GetAllInclude()
        .Include(p => p.ProductSizes) // ProductSizes ilişkisinin yüklenmesini sağlıyor
        .Include(p => p.ProductCategories) // İlişkili kategori verilerini yüklemek için
        .Include(p => p.ProductRegions) // İlişkili bölge verilerini yüklemek için
        .Include(p => p.ProductSubRegions) // İlişkili alt bölge verilerini yüklemek için
        .Where(p => p.ProductCategoryId == "3kına" && p.IsSale == false)
        .ToList();

            var viewModel = products.Select(product =>
            {
                // Ürün beden bilgilerini ve beden sayılarını çekiyoruz
                var sizesWithAmounts = product.ProductSizes
                    .Select(ps => (SizeNumber: ps.SizeNumber, SizeAmount: ps.SizeAmount))
                    .ToList();

                // Kategori, bölge ve alt bölge adlarını çekiyoruz
                var categoryName = product.ProductCategories?.Name;
                var regionName = product.ProductRegions?.Name;
                var subRegionName = product.ProductSubRegions?.Name;

                return new ProductAdminVM
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    IsAdult = product.IsAdult,
                    SizesWithAmounts = sizesWithAmounts, // Beden ve Beden Sayısı Eşleştirmesi
                    UnitPriceForRent = product.UnitPriceForRent,
                    UnitPriceForSale = product.UnitPriceForSale,
                    IsSale = product.IsSale,
                    Gender = product.Gender,
                    PhotoPath = product.PhotoPath,
                    CategoryName = categoryName,
                    RegionName = regionName,
                    SubRegionName = subRegionName,
                };
            }).ToList();

            return View(viewModel);
        }
        [Authorize]
        [HttpGet]
        public IActionResult ProductInsert()
        {
            // Kategori, bölge ve alt bölge seçimleri için veri getir
            var categories = productCategoryManager.GetAll();
            var regions = productRegionManager.GetAll();
            var subRegions = productSubRegionManager.GetAll();
            var sizes = sizeManager.GetAll();

            var sizeOptions = sizes.Select(s => new SelectListItem
            {
                Value = s.Id,
                Text = s.SizeNumber.ToString() // Örneğin "38", "40"
            }).ToList();

            // ViewModel oluştur ve veri aktar
            var viewModel = new ProductInsertAdminVM
            {
                Categories = categories,
                Regions = regions,
                SubRegions = subRegions,
                SizeOptions = sizeOptions,
                SelectedSizes = new List<SelectedSizeVM> { new SelectedSizeVM() }
            };


            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductInsert(ProductInsertAdminVM productInsertAdminVM)
        {


            if (!ModelState.IsValid)
            {
                productInsertAdminVM.Categories = productCategoryManager.GetAll();
                productInsertAdminVM.Regions = productRegionManager.GetAll();
                productInsertAdminVM.SubRegions = productSubRegionManager.GetAll();
                productInsertAdminVM.SizeOptions = sizeManager.GetAll().Select(s => new SelectListItem
                {
                    Value = s.Id,
                    Text = s.SizeNumber.ToString()
                }).ToList();

                return View(productInsertAdminVM);
            }


            #region Fotograf Kaydetme
            string uploads = "";
            string userImagePath = "";
            if (productInsertAdminVM.Picture != null
                && (productInsertAdminVM.Picture.ContentType.Contains("image/jpeg") || productInsertAdminVM.Picture.ContentType.Contains("image/png")))
            {
                //Dosya ismin alma 
                var fileName = Path.GetFileName(productInsertAdminVM.Picture.FileName);
                //Dosya Extension bulma
                var extension = Path.GetExtension(fileName);
                //Birlestirme işlemi 
                var newFileName = string.Concat(Guid.NewGuid().ToString(), extension);
                userImagePath = $@"/databaseimg/{newFileName}";
                uploads = Path.Combine(hostEnvironment.ContentRootPath, $@"wwwroot/databaseimg/{newFileName}");
                string filePath = Path.Combine(uploads, newFileName);
                using (var fileStream = new System.IO.FileStream(uploads, FileMode.Create))
                {
                    await fileStream.CopyToAsync(fileStream);
                }
            }
            #endregion


            var product = new Product
            {
                ProductName = productInsertAdminVM.ProductName,
                Description = productInsertAdminVM.Description,
                IsAdult = productInsertAdminVM.IsAdult,
                UnitPriceForSale = productInsertAdminVM.UnitPriceForSale,
                UnitPriceForRent = productInsertAdminVM.UnitPriceForRent,
                IsSale = productInsertAdminVM.IsSale,
                Gender = productInsertAdminVM.Gender,
                PhotoPath = userImagePath,
                ProductCategoryId = productInsertAdminVM.SelectedCategoryId,
                ProductRegionId = productInsertAdminVM.SelectedRegionId,
                ProductSubRegionId = productInsertAdminVM.SelectedSubRegionId,


            };


            productManager.Create(product);

            // Bedeni ve stok miktarını kaydet
            if (productInsertAdminVM.SelectedSizes != null && productInsertAdminVM.SelectedSizes.Any())
            {
                foreach (var selectedSize in productInsertAdminVM.SelectedSizes)
                {
                    // SizeNumber'ı SizeId üzerinden al
                    var size = sizeManager.GetById(selectedSize.SizeId);
                    var productSize = new ProductSize
                    {
                        ProductId = product.Id,
                        SizeId = selectedSize.SizeId, // SizeId string olarak kullanılıyor
                        SizeNumber = size != null ? size.SizeNumber : 0, // SizeNumber atanıyor
                        SizeAmount = selectedSize.SizeAmount
                    };
                    productSizeManager.Create(productSize);
                }
            }


            // Başarı mesajı ve yönlendirme
            notyfService.Success("Ürün başarıyla eklendi.");
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult KiralıkDansIndex()
        {
            var products = productManager.GetAllInclude()
         .Include(p => p.ProductSizes) // ProductSizes ilişkisinin yüklenmesini sağlıyor
         .Include(p => p.ProductCategories) // İlişkili kategori verilerini yüklemek için
         .Include(p => p.ProductRegions) // İlişkili bölge verilerini yüklemek için
         .Include(p => p.ProductSubRegions) // İlişkili alt bölge verilerini yüklemek için
         .Where(p => p.ProductCategoryId == "4dans" && p.IsSale == false)
         .ToList();

            var viewModel = products.Select(product =>
            {
                // Ürün beden bilgilerini ve beden sayılarını çekiyoruz
                var sizesWithAmounts = product.ProductSizes
                    .Select(ps => (SizeNumber: ps.SizeNumber, SizeAmount: ps.SizeAmount))
                    .ToList();

                // Kategori, bölge ve alt bölge adlarını çekiyoruz
                var categoryName = product.ProductCategories?.Name;
                var regionName = product.ProductRegions?.Name;
                var subRegionName = product.ProductSubRegions?.Name;

                return new ProductAdminVM
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    IsAdult = product.IsAdult,
                    SizesWithAmounts = sizesWithAmounts, // Beden ve Beden Sayısı Eşleştirmesi
                    UnitPriceForRent = product.UnitPriceForRent,
                    UnitPriceForSale = product.UnitPriceForSale,
                    IsSale = product.IsSale,
                    Gender = product.Gender,
                    PhotoPath = product.PhotoPath,
                    CategoryName = categoryName,
                    RegionName = regionName,
                    SubRegionName = subRegionName,
                };
            }).ToList();

            return View(viewModel);
        }
        [Authorize]
        public IActionResult KiralıkHalkOyunIndex()
        {
            var products = productManager.GetAllInclude()
         .Include(p => p.ProductSizes) // ProductSizes ilişkisinin yüklenmesini sağlıyor
         .Include(p => p.ProductCategories) // İlişkili kategori verilerini yüklemek için
         .Include(p => p.ProductRegions) // İlişkili bölge verilerini yüklemek için
         .Include(p => p.ProductSubRegions) // İlişkili alt bölge verilerini yüklemek için
         .Where(p => p.ProductCategoryId == "2halkoyun" && p.IsSale == false)
         .ToList();

            var viewModel = products.Select(product =>
            {
                // Ürün beden bilgilerini ve beden sayılarını çekiyoruz
                var sizesWithAmounts = product.ProductSizes
                    .Select(ps => (SizeNumber: ps.SizeNumber, SizeAmount: ps.SizeAmount))
                    .ToList();

                // Kategori, bölge ve alt bölge adlarını çekiyoruz
                var categoryName = product.ProductCategories?.Name;
                var regionName = product.ProductRegions?.Name;
                var subRegionName = product.ProductSubRegions?.Name;

                return new ProductAdminVM
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    IsAdult = product.IsAdult,
                    SizesWithAmounts = sizesWithAmounts, // Beden ve Beden Sayısı Eşleştirmesi
                    UnitPriceForRent = product.UnitPriceForRent,
                    UnitPriceForSale = product.UnitPriceForSale,
                    IsSale = product.IsSale,
                    Gender = product.Gender,
                    PhotoPath = product.PhotoPath,
                    CategoryName = categoryName,
                    RegionName = regionName,
                    SubRegionName = subRegionName,
                };
            }).ToList();

            return View(viewModel);
        }
        [Authorize]
        public IActionResult KiralıkRondIndex()
        {
            var products = productManager.GetAllInclude()
        .Include(p => p.ProductSizes) // ProductSizes ilişkisinin yüklenmesini sağlıyor
        .Include(p => p.ProductCategories) // İlişkili kategori verilerini yüklemek için
        .Include(p => p.ProductRegions) // İlişkili bölge verilerini yüklemek için
        .Include(p => p.ProductSubRegions) // İlişkili alt bölge verilerini yüklemek için
        .Where(p => p.ProductCategoryId == "5rond" && p.IsSale == false)
        .ToList();

            var viewModel = products.Select(product =>
            {
                // Ürün beden bilgilerini ve beden sayılarını çekiyoruz
                var sizesWithAmounts = product.ProductSizes
                    .Select(ps => (SizeNumber: ps.SizeNumber, SizeAmount: ps.SizeAmount))
                    .ToList();

                // Kategori, bölge ve alt bölge adlarını çekiyoruz
                var categoryName = product.ProductCategories?.Name;
                var regionName = product.ProductRegions?.Name;
                var subRegionName = product.ProductSubRegions?.Name;

                return new ProductAdminVM
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    IsAdult = product.IsAdult,
                    SizesWithAmounts = sizesWithAmounts, // Beden ve Beden Sayısı Eşleştirmesi
                    UnitPriceForRent = product.UnitPriceForRent,
                    UnitPriceForSale = product.UnitPriceForSale,
                    IsSale = product.IsSale,
                    Gender = product.Gender,
                    PhotoPath = product.PhotoPath,
                    CategoryName = categoryName,
                    RegionName = regionName,
                    SubRegionName = subRegionName,
                };
            }).ToList();

            return View(viewModel);
        }
        [Authorize]
        public IActionResult SatılıkHalkOyunIndex()
        {
            var products = productManager.GetAllInclude()
         .Include(p => p.ProductSizes) // ProductSizes ilişkisinin yüklenmesini sağlıyor
         .Include(p => p.ProductCategories) // İlişkili kategori verilerini yüklemek için
         .Include(p => p.ProductRegions) // İlişkili bölge verilerini yüklemek için
         .Include(p => p.ProductSubRegions) // İlişkili alt bölge verilerini yüklemek için
         .Where(p => p.ProductCategoryId == "2halkoyun" && p.IsSale == true)
         .ToList();

            var viewModel = products.Select(product =>
            {
                // Ürün beden bilgilerini ve beden sayılarını çekiyoruz
                var sizesWithAmounts = product.ProductSizes
                    .Select(ps => (SizeNumber: ps.SizeNumber, SizeAmount: ps.SizeAmount))
                    .ToList();

                // Kategori, bölge ve alt bölge adlarını çekiyoruz
                var categoryName = product.ProductCategories?.Name;
                var regionName = product.ProductRegions?.Name;
                var subRegionName = product.ProductSubRegions?.Name;

                return new ProductAdminVM
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    IsAdult = product.IsAdult,
                    SizesWithAmounts = sizesWithAmounts, // Beden ve Beden Sayısı Eşleştirmesi
                    UnitPriceForRent = product.UnitPriceForRent,
                    UnitPriceForSale = product.UnitPriceForSale,
                    IsSale = product.IsSale,
                    Gender = product.Gender,
                    PhotoPath = product.PhotoPath,
                    CategoryName = categoryName,
                    RegionName = regionName,
                    SubRegionName = subRegionName,
                };
            }).ToList();

            return View(viewModel);
        }
        [Authorize]
        [HttpGet]
        public IActionResult ProductEdit(string Id)
        {
            var product = productManager.GetAllInclude(p => p.Id == Id).FirstOrDefault();
            if (product == null)
            {
                notyfService.Error("Ürün bulunamadı.");
                return RedirectToAction("Index", "Home");
            }

            var productEditAdminVM = new ProductEditAdminVM();
            productEditAdminVM.Id = Id;
            productEditAdminVM.ProductName = product.ProductName;
            productEditAdminVM.Description = product.Description;
            productEditAdminVM.IsAdult = product.IsAdult;
            productEditAdminVM.UnitPriceForSale = product.UnitPriceForSale;
            productEditAdminVM.UnitPriceForRent = product.UnitPriceForRent;
            productEditAdminVM.IsSale = product.IsSale;
            productEditAdminVM.Gender = product.Gender;
            //userImagePath = product.PhotoPath; //get de bu olmayacak
            productEditAdminVM.ProductCategoryId = product.ProductCategoryId;
            productEditAdminVM.ProductRegionId = product.ProductRegionId;
            productEditAdminVM.ProductSubRegionId = product.ProductSubRegionId;
            productEditAdminVM.PhotoPath = product.PhotoPath;


            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult ProductEdit(ProductInsertAdminVM productInsertAdminVM)
        {

            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult ProductDelete(string productId)
        {
            try
            {
                //Ürünü bul
                var product = productManager.GetAll(p => p.Id == productId).FirstOrDefault();

                if (product == null)
                {
                    notyfService.Error("Ürün bulunamadı.");
                    return RedirectToAction("Index", "Home");
                }

                // Ürünü sil
                productManager.Delete(product);
                notyfService.Success("Ürün başarıyla silindi.");
            }
            catch (Exception ex)
            {
                notyfService.Error("Hata oluştu: " + ex.Message);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
