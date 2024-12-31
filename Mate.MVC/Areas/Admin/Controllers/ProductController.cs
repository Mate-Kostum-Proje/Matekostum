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
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

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
        [Authorize]
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
            var size2 = sizeManager.GetAll();

            var sizes = size2.Select(s => new SelectListItem
            {
                Value = s.Id,
                Text = s.SizeNumber.ToString() // Örneğin "38", "40"
            }).ToList();

            ViewData["Sizes"] = sizes;
            // ViewModel oluştur ve veri aktar
            var viewModel = new ProductInsertAdminVM
            {
                Categories = categories,
                Regions = regions,
                SubRegions = subRegions,

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
                ViewData["Sizes"] = sizeManager.GetAll().Select(s => new SelectListItem
                {
                    Value = s.Id,
                    Text = s.SizeNumber.ToString()
                }).ToList();

                return View(productInsertAdminVM);
            }
            productInsertAdminVM.Categories = productCategoryManager.GetAll();
            productInsertAdminVM.Regions = productRegionManager.GetAll();
            productInsertAdminVM.SubRegions = productSubRegionManager.GetAll();



            var product = new Product
            {
                ProductName = productInsertAdminVM.ProductName,
                Description = productInsertAdminVM.Description,
                IsAdult = productInsertAdminVM.IsAdult,
                UnitPriceForSale = productInsertAdminVM.UnitPriceForSale,
                UnitPriceForRent = productInsertAdminVM.UnitPriceForRent,
                IsSale = productInsertAdminVM.IsSale,
                Gender = productInsertAdminVM.Gender,
                ProductCategoryId = productInsertAdminVM.SelectedCategoryId,
                ProductRegionId = productInsertAdminVM.SelectedRegionId,
                ProductSubRegionId = productInsertAdminVM.SelectedSubRegionId,


            };

            #region Fotograf Kaydetme
            if (productInsertAdminVM.Picture != null && productInsertAdminVM.Picture.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/databaseimg");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var uniqueFileName = $"{Guid.NewGuid()}_{productInsertAdminVM.Picture.FileName}";
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await productInsertAdminVM.Picture.CopyToAsync(fileStream);
                }

                product.PhotoPath = $"/databaseimg/{uniqueFileName}";
            }
            #endregion


            productManager.Create(product);

            string createdProductId = product.Id;

            // Bedeni ve stok miktarını kaydet
            var allSizes = sizeManager.GetAll(); // Tüm bedenleri al

            foreach (var selectedSize in productInsertAdminVM.SelectedSizes)
            {
                if (!string.IsNullOrEmpty(selectedSize.SizeId) && selectedSize.SizeAmount > 0)
                {
                    // SizeId'ye göre SizeNumber'ı alın
                    var size = sizeManager.GetById(selectedSize.SizeId); // `sizeManager.GetById` uygun metodu çağırın
                    var sizeNumber = size != null ? size.SizeNumber : 0; // Eğer size bulunamazsa 0 yap

                    var productSize = new ProductSize
                    {
                        ProductId = product.Id,
                        SizeId = selectedSize.SizeId,
                        SizeAmount = selectedSize.SizeAmount,
                        SizeNumber = sizeNumber // SizeNumber'ı atıyoruz
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
            var product = productManager.GetAllInclude(p => p.Id == Id).Include(p => p.ProductSizes).FirstOrDefault();
            if (product == null)
            {
                notyfService.Error("Ürün bulunamadı.");
                return RedirectToAction("Index", "Home");
            }

            var categories = productCategoryManager.GetAll();
            var regions = productRegionManager.GetAll();
            var subRegions = productSubRegionManager.GetAll();
            var size2 = sizeManager.GetAll();



            var allSizes = sizeManager.GetAll();

            var selectedSizes = product.ProductSizes.Select(ps => new SelectedSizeVM
            {
                SizeId = ps.SizeId,
                SizeNumber = allSizes.FirstOrDefault(s => s.Id == ps.SizeId)?.SizeNumber ?? 0,
                SizeAmount = ps.SizeAmount
            }).ToList();



            var productEditAdminVM = new ProductEditAdminVM
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Description = product.Description,
                IsAdult = product.IsAdult,
                UnitPriceForSale = product.UnitPriceForSale,
                UnitPriceForRent = product.UnitPriceForRent,
                IsSale = product.IsSale,
                Gender = product.Gender,
                ProductCategoryId = product.ProductCategoryId,
                ProductRegionId = product.ProductRegionId,
                ProductSubRegionId = product.ProductSubRegionId,
                SelectedCategoryId = product.ProductCategoryId,
                SelectedRegionId = product.ProductRegionId,
                SelectedSubRegionId = product.ProductSubRegionId,
                PhotoPath = product.PhotoPath,
                Categories = categories,
                Regions = regions,
                SubRegions = subRegions,
                SelectedSizes = selectedSizes,
                AllSizes = allSizes
            };

            ViewData["Sizes"] = productEditAdminVM.AllSizes.Select(size => new
            {
                Value = size.Id,
                Text = size.SizeNumber
            }).ToList();

            return View(productEditAdminVM);
        }


        [Authorize]
        [HttpPost]

        public async Task<IActionResult> ProductEdit(ProductEditAdminVM productEditAdminVM)
        {
            if (!ModelState.IsValid)
            {


                notyfService.Error("Lütfen gerekli alanları doldurun.");
                return View(productEditAdminVM);
            }
            productEditAdminVM.Categories = productCategoryManager.GetAll();
            productEditAdminVM.Regions = productRegionManager.GetAll();
            productEditAdminVM.SubRegions = productSubRegionManager.GetAll();
            ViewData["Sizes"] = sizeManager.GetAll().Select(s => new SelectListItem
            {
                Value = s.Id,
                Text = s.SizeNumber.ToString()
            }).ToList();
            var product = productManager.GetById(productEditAdminVM.Id);
            if (product == null)
            {
                notyfService.Error("Ürün bulunamadı.");
                return RedirectToAction("Index", "Home");
            }

            product.ProductName = productEditAdminVM.ProductName;
            product.Description = productEditAdminVM.Description;
            product.IsAdult = productEditAdminVM.IsAdult;
            product.UnitPriceForSale = productEditAdminVM.UnitPriceForSale;
            product.UnitPriceForRent = productEditAdminVM.UnitPriceForRent;
            product.IsSale = productEditAdminVM.IsSale;
            product.Gender = productEditAdminVM.Gender;
            product.ProductCategoryId = productEditAdminVM.ProductCategoryId;
            product.ProductRegionId = productEditAdminVM.ProductRegionId;
            product.ProductSubRegionId = productEditAdminVM.ProductSubRegionId;



            #region Foto Koyma
            if (productEditAdminVM.Picture != null && productEditAdminVM.Picture.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/databaseimg");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var uniqueFileName = $"{Guid.NewGuid()}_{productEditAdminVM.Picture.FileName}";
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await productEditAdminVM.Picture.CopyToAsync(fileStream);
                }

                // Eski fotoğrafı silmek
                if (!string.IsNullOrEmpty(product.PhotoPath))
                {
                    var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", product.PhotoPath);
                    if (System.IO.File.Exists(oldFilePath))
                    {
                        System.IO.File.Delete(oldFilePath);
                        product.PhotoPath = $"/databaseimg/{uniqueFileName}";
                    }
                    else
                    {
                        product.PhotoPath = oldFilePath;
                    }
                }

                // Yeni fotoğrafın yolunu kaydet

            }
            #endregion


            foreach (var selectedSize in productEditAdminVM.SelectedSizes)
            {
                if (!string.IsNullOrEmpty(selectedSize.SizeId) && selectedSize.SizeAmount > 0)
                {
                    var existingProductSize = productSizeManager.GetAll()
                        .FirstOrDefault(ps => ps.ProductId == product.Id && ps.SizeId == selectedSize.SizeId);

                    if (existingProductSize != null)
                    {
                        // Güncelle
                        existingProductSize.SizeAmount = selectedSize.SizeAmount;
                        productSizeManager.Update(existingProductSize);
                    }
                    else
                    {
                        // Yeni kayıt ekle
                        var newProductSize = new ProductSize
                        {
                            ProductId = product.Id,
                            SizeId = selectedSize.SizeId,
                            SizeAmount = selectedSize.SizeAmount,
                            SizeNumber = sizeManager.GetById(selectedSize.SizeId)?.SizeNumber ?? 0
                        };
                        productSizeManager.Create(newProductSize);
                    }
                }
            }


            productManager.Update(product);
            notyfService.Success("Ürün başarıyla güncellendi.");
            return RedirectToAction("Index", "Home");
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
