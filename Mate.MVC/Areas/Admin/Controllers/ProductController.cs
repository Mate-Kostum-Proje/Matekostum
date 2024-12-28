using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Mate.BL.Abstract;
using Mate.Entities.Concrete;
using Mate.MVC.Areas.Admin.Models_VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

            // ViewModel oluştur ve veri aktar
            var viewModel = new ProductInsertAdminVM
            {
                Categories = categories,
                Regions = regions,
                SubRegions = subRegions
            };


            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductInsert(ProductInsertAdminVM productInsertAdminVM)
        {

            // Model doğrulama
            if (!ModelState.IsValid)
            {

                productInsertAdminVM.Categories = productCategoryManager.GetAll();
                productInsertAdminVM.Regions = productRegionManager.GetAll();
                productInsertAdminVM.SubRegions = productSubRegionManager.GetAll();


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

            // Yeni ürün oluştur
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
                ProductCategoryId = productInsertAdminVM.ProductCategoryId,
                ProductRegionId = productInsertAdminVM.ProductRegionId,
                ProductSubRegionId = productInsertAdminVM.ProductSubRegionId,


            };

            // Ürünü kaydet
            productManager.Create(product);

            // Bedeni ve stok miktarını kaydet
            if (productInsertAdminVM.SizesWithAmounts != null && productInsertAdminVM.SizesWithAmounts.Any())
            {
                foreach (var sizeWithAmount in productInsertAdminVM.SizesWithAmounts)
                {
                    var productSize = new ProductSize
                    {
                        ProductId = product.Id,
                        SizeId = sizeWithAmount.SizeId,
                        SizeNumber = sizeWithAmount.SizeNumber,
                        SizeAmount = sizeWithAmount.SizeAmount
                    };

                    productSizeManager.Create(productSize);
                }
            }

            // Başarı mesajı ve yönlendirme
            notyfService.Success("Ürün başarıyla eklendi.");
            return RedirectToAction("KiralıkBindallıIndex");
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

            var productInsertAdminVM = new ProductInsertAdminVM();
            productInsertAdminVM.Id = Id;
            productInsertAdminVM.ProductName = product.ProductName;
            productInsertAdminVM.Description = product.Description;
            productInsertAdminVM.IsAdult = product.IsAdult;
            productInsertAdminVM.UnitPriceForSale = product.UnitPriceForSale;
            productInsertAdminVM.UnitPriceForRent = product.UnitPriceForRent;
            productInsertAdminVM.IsSale = product.IsSale;
            productInsertAdminVM.Gender = product.Gender;
            //userImagePath = product.PhotoPath;
            productInsertAdminVM.ProductCategoryId = product.ProductCategoryId;
            productInsertAdminVM.ProductRegionId = product.ProductRegionId;
            productInsertAdminVM.ProductSubRegionId = product.ProductSubRegionId;



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
                //Kullanıcıyı bul
                var product = productManager.GetAllInclude(p => p.Id == productId).FirstOrDefault();

                if (product == null)
                {
                    notyfService.Error("Ürün bulunamadı.");
                    return RedirectToAction("Index", "Home");
                }

                // Kullanıcıyı sil
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
