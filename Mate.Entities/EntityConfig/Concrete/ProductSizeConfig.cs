using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class ProductSizeConfig : BaseConfig<ProductSize>
    {
        public override void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            base.Configure(builder);
            builder.HasKey(ps => new { ps.ProductId, ps.SizeId });

            builder.HasOne(p => p.Sizes).WithMany(p => p.ProductSizes).HasForeignKey(p => p.SizeId).IsRequired();
            builder.HasOne(p => p.Products).WithMany(p => p.ProductSizes).HasForeignKey(p => p.ProductId).IsRequired();



            builder.HasIndex(p => p.SizeNumber);

            builder.HasIndex(P => P.SizeAmount);


            #region Data
            //1.HALK OYUNLARI ÇOCUK

            builder.HasData(new ProductSize { ProductId = "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", SizeNumber = 8, SizeAmount = 4, });
            builder.HasData(new ProductSize { ProductId = "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", SizeNumber = 10, SizeAmount = 5 });
            builder.HasData(new ProductSize { ProductId = "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9", SizeNumber = 12, SizeAmount = 6 });
            builder.HasData(new ProductSize { ProductId = "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4", SizeNumber = 14, SizeAmount = 7 });

            builder.HasData(new ProductSize { ProductId = "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b5b67003-636d-425d-9784-45d374db713c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b5b67003-636d-425d-9784-45d374db713c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b5b67003-636d-425d-9784-45d374db713c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b5b67003-636d-425d-9784-45d374db713c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2x", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f39485eb-f82b-495c-8b60-7dada21ee477", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f39485eb-f82b-495c-8b60-7dada21ee477", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f39485eb-f82b-495c-8b60-7dada21ee477", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f39485eb-f82b-495c-8b60-7dada21ee477", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "50680664-523a-475b-869f-0aa5e0cd88b4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "50680664-523a-475b-869f-0aa5e0cd88b4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "50680664-523a-475b-869f-0aa5e0cd88b4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "50680664-523a-475b-869f-0aa5e0cd88b4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0c59ca0d-60e5-4686-80be-18ab36b53468", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0c59ca0d-60e5-4686-80be-18ab36b53468", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0c59ca0d-60e5-4686-80be-18ab36b53468", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0c59ca0d-60e5-4686-80be-18ab36b53468", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "dd438551-3d93-45bc-982d-7c338b69983b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "dd438551-3d93-45bc-982d-7c338b69983b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "dd438551-3d93-45bc-982d-7c338b69983b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "dd438551-3d93-45bc-982d-7c338b69983b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "43606bc6-5874-4469-bcdf-fe1b86f66882", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "43606bc6-5874-4469-bcdf-fe1b86f66882", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "43606bc6-5874-4469-bcdf-fe1b86f66882", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "43606bc6-5874-4469-bcdf-fe1b86f66882", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2146af26-ce2b-461b-883b-e6f4fe0c8085", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2146af26-ce2b-461b-883b-e6f4fe0c8085", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2146af26-ce2b-461b-883b-e6f4fe0c8085", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2146af26-ce2b-461b-883b-e6f4fe0c8085", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6f169352-0f68-4d11-b562-f693a0158100", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6f169352-0f68-4d11-b562-f693a0158100", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6f169352-0f68-4d11-b562-f693a0158100", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6f169352-0f68-4d11-b562-f693a0158100", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ad918937-0645-4b89-86d5-0672662fd46e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ad918937-0645-4b89-86d5-0672662fd46e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ad918937-0645-4b89-86d5-0672662fd46e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ad918937-0645-4b89-86d5-0672662fd46e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "23672a63-2fd2-4e6a-905b-340ae4456b83", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "23672a63-2fd2-4e6a-905b-340ae4456b83", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "23672a63-2fd2-4e6a-905b-340ae4456b83", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "23672a63-2fd2-4e6a-905b-340ae4456b83", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "7d543840-b11e-4380-a147-7dab483cf5ce", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7d543840-b11e-4380-a147-7dab483cf5ce", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7d543840-b11e-4380-a147-7dab483cf5ce", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7d543840-b11e-4380-a147-7dab483cf5ce", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "bd0cb50a-e769-48ed-8473-b25faa687e15", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "bd0cb50a-e769-48ed-8473-b25faa687e15", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "bd0cb50a-e769-48ed-8473-b25faa687e15", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "bd0cb50a-e769-48ed-8473-b25faa687e15", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d501bc94-2256-4ce7-b0bf-be4357ada814", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d501bc94-2256-4ce7-b0bf-be4357ada814", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d501bc94-2256-4ce7-b0bf-be4357ada814", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d501bc94-2256-4ce7-b0bf-be4357ada814", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4aa47021-28ed-4c36-81c3-6e2734d3873b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4aa47021-28ed-4c36-81c3-6e2734d3873b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4aa47021-28ed-4c36-81c3-6e2734d3873b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4aa47021-28ed-4c36-81c3-6e2734d3873b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "78157107-23fa-4638-bd17-38187695312c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "78157107-23fa-4638-bd17-38187695312c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "78157107-23fa-4638-bd17-38187695312c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "78157107-23fa-4638-bd17-38187695312c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a278895c-19b5-45c6-92f9-48c5f2724e8a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a278895c-19b5-45c6-92f9-48c5f2724e8a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a278895c-19b5-45c6-92f9-48c5f2724e8a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a278895c-19b5-45c6-92f9-48c5f2724e8a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            //3. STİLİZE DANS ÇOCUK



            builder.HasData(new ProductSize { ProductId = "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5a382843-9817-449b-b9d8-4e48d90aef5e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5a382843-9817-449b-b9d8-4e48d90aef5e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5a382843-9817-449b-b9d8-4e48d90aef5e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5a382843-9817-449b-b9d8-4e48d90aef5e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "618fdb18-11c3-4166-9bb1-79298a32a7a4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "618fdb18-11c3-4166-9bb1-79298a32a7a4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "618fdb18-11c3-4166-9bb1-79298a32a7a4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "618fdb18-11c3-4166-9bb1-79298a32a7a4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2e5e4216-4af5-4fb6-9c65-8989715e5a40", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2e5e4216-4af5-4fb6-9c65-8989715e5a40", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2e5e4216-4af5-4fb6-9c65-8989715e5a40", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2e5e4216-4af5-4fb6-9c65-8989715e5a40", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "77035e08-21a9-4149-8d7c-d4266f88ad03", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "77035e08-21a9-4149-8d7c-d4266f88ad03", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "77035e08-21a9-4149-8d7c-d4266f88ad03", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "77035e08-21a9-4149-8d7c-d4266f88ad03", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "43ca244e-8d5a-468b-b327-ce6bdc541cf7", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "43ca244e-8d5a-468b-b327-ce6bdc541cf7", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "43ca244e-8d5a-468b-b327-ce6bdc541cf7", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "43ca244e-8d5a-468b-b327-ce6bdc541cf7", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4a67e8f3-4dec-41ad-a5e7-18995a14535d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4a67e8f3-4dec-41ad-a5e7-18995a14535d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4a67e8f3-4dec-41ad-a5e7-18995a14535d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4a67e8f3-4dec-41ad-a5e7-18995a14535d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d6003f61-89ae-4240-b53c-542ab36728ca", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d6003f61-89ae-4240-b53c-542ab36728ca", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d6003f61-89ae-4240-b53c-542ab36728ca", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d6003f61-89ae-4240-b53c-542ab36728ca", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "1a9626f8-303d-41e3-aa54-ae1a971ad179", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "1a9626f8-303d-41e3-aa54-ae1a971ad179", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "1a9626f8-303d-41e3-aa54-ae1a971ad179", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "1a9626f8-303d-41e3-aa54-ae1a971ad179", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3770c1af-e181-494b-8c1a-c6f09a3b825a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3770c1af-e181-494b-8c1a-c6f09a3b825a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3770c1af-e181-494b-8c1a-c6f09a3b825a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3770c1af-e181-494b-8c1a-c6f09a3b825a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            //ÇOCUK 4. ROND TÖREN
            // Kiralık Yıl Sonu Gösteri Kıyafetleri - Asker Kıyafeti Kiralama-Çanakkale Askeri Kıyafeti
            //KİRALIK ÇOCUK GÖSTERİ ve TÖREN KOSTÜMLERİ


            builder.HasData(new ProductSize { ProductId = "a2bcb56b-1da2-43fc-b133-3b5c04603123", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a2bcb56b-1da2-43fc-b133-3b5c04603123", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a2bcb56b-1da2-43fc-b133-3b5c04603123", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a2bcb56b-1da2-43fc-b133-3b5c04603123", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6bdd753a-2706-48b6-b485-23c989a5f326", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6bdd753a-2706-48b6-b485-23c989a5f326", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6bdd753a-2706-48b6-b485-23c989a5f326", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6bdd753a-2706-48b6-b485-23c989a5f326", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "121345d8-2660-489c-a90d-2469b9c44222", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "121345d8-2660-489c-a90d-2469b9c44222", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "121345d8-2660-489c-a90d-2469b9c44222", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "121345d8-2660-489c-a90d-2469b9c44222", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b8b726c6-227d-4267-8dba-c1bf5ec0301f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b8b726c6-227d-4267-8dba-c1bf5ec0301f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b8b726c6-227d-4267-8dba-c1bf5ec0301f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b8b726c6-227d-4267-8dba-c1bf5ec0301f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6e0185cc-235f-4603-9470-5f4ca7c92514", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6e0185cc-235f-4603-9470-5f4ca7c92514", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6e0185cc-235f-4603-9470-5f4ca7c92514", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6e0185cc-235f-4603-9470-5f4ca7c92514", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cd3be091-3d72-4512-ba1d-e8466285b930", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cd3be091-3d72-4512-ba1d-e8466285b930", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cd3be091-3d72-4512-ba1d-e8466285b930", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cd3be091-3d72-4512-ba1d-e8466285b930", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4b656abf-bdc5-4058-a12b-488d93cc1677", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4b656abf-bdc5-4058-a12b-488d93cc1677", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4b656abf-bdc5-4058-a12b-488d93cc1677", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4b656abf-bdc5-4058-a12b-488d93cc1677", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c35ccc97-39f5-4396-bbe1-2a6171f30d10", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c35ccc97-39f5-4396-bbe1-2a6171f30d10", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c35ccc97-39f5-4396-bbe1-2a6171f30d10", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c35ccc97-39f5-4396-bbe1-2a6171f30d10", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "809d901e-d7de-4fec-aa95-655deb2301b6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "809d901e-d7de-4fec-aa95-655deb2301b6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "809d901e-d7de-4fec-aa95-655deb2301b6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "809d901e-d7de-4fec-aa95-655deb2301b6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f03ff26b-30e9-4a60-b99a-780060db1e35", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f03ff26b-30e9-4a60-b99a-780060db1e35", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f03ff26b-30e9-4a60-b99a-780060db1e35", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f03ff26b-30e9-4a60-b99a-780060db1e35", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "72d46b9b-612d-41c4-8303-8f8571771de9", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "72d46b9b-612d-41c4-8303-8f8571771de9", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "72d46b9b-612d-41c4-8303-8f8571771de9", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "72d46b9b-612d-41c4-8303-8f8571771de9", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "229759ff-14dd-4c4e-82aa-f56a2181c0ad", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "229759ff-14dd-4c4e-82aa-f56a2181c0ad", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "229759ff-14dd-4c4e-82aa-f56a2181c0ad", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "229759ff-14dd-4c4e-82aa-f56a2181c0ad", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3e2f7a5f-b665-4b13-861e-c5a5029216a0", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3e2f7a5f-b665-4b13-861e-c5a5029216a0", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3e2f7a5f-b665-4b13-861e-c5a5029216a0", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3e2f7a5f-b665-4b13-861e-c5a5029216a0", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cae31f17-a52f-4ac3-97bb-6886500b19bf", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cae31f17-a52f-4ac3-97bb-6886500b19bf", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cae31f17-a52f-4ac3-97bb-6886500b19bf", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cae31f17-a52f-4ac3-97bb-6886500b19bf", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ed9ab94a-9354-48de-8695-43131a67bd2c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ed9ab94a-9354-48de-8695-43131a67bd2c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ed9ab94a-9354-48de-8695-43131a67bd2c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ed9ab94a-9354-48de-8695-43131a67bd2c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c941ed50-01c0-472d-8122-3756b9b55a29", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c941ed50-01c0-472d-8122-3756b9b55a29", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c941ed50-01c0-472d-8122-3756b9b55a29", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c941ed50-01c0-472d-8122-3756b9b55a29", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a34e2f74-5403-4e43-bc88-30019ebd460f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a34e2f74-5403-4e43-bc88-30019ebd460f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a34e2f74-5403-4e43-bc88-30019ebd460f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a34e2f74-5403-4e43-bc88-30019ebd460f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8906cf96-12d6-4eca-8a0b-d39dd78dc597", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8906cf96-12d6-4eca-8a0b-d39dd78dc597", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8906cf96-12d6-4eca-8a0b-d39dd78dc597", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8906cf96-12d6-4eca-8a0b-d39dd78dc597", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b2b71d89-5501-4bd6-a358-aca8ce706bdb", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b2b71d89-5501-4bd6-a358-aca8ce706bdb", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b2b71d89-5501-4bd6-a358-aca8ce706bdb", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b2b71d89-5501-4bd6-a358-aca8ce706bdb", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            ////YETİŞKİN KİRALIK
            ////1.HALK OYUNLARI YETİŞKİN
            ////YETİSKİNYÖRESELKIYAFETLERİ

            builder.HasData(new ProductSize { ProductId = "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "01388782-b75d-4762-8ccf-4499568fd455", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "01388782-b75d-4762-8ccf-4499568fd455", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "01388782-b75d-4762-8ccf-4499568fd455", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "01388782-b75d-4762-8ccf-4499568fd455", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5b26e8ac-df32-4b9d-8992-047e22372332", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5b26e8ac-df32-4b9d-8992-047e22372332", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5b26e8ac-df32-4b9d-8992-047e22372332", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5b26e8ac-df32-4b9d-8992-047e22372332", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5754a3be-8508-452d-8a64-9d752bde4f70", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5754a3be-8508-452d-8a64-9d752bde4f70", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5754a3be-8508-452d-8a64-9d752bde4f70", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5754a3be-8508-452d-8a64-9d752bde4f70", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6eee1f90-a40d-4d95-9ca6-0e45689398be", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6eee1f90-a40d-4d95-9ca6-0e45689398be", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6eee1f90-a40d-4d95-9ca6-0e45689398be", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6eee1f90-a40d-4d95-9ca6-0e45689398be", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cf03ef83-babf-4710-ab13-ace35476b474", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cf03ef83-babf-4710-ab13-ace35476b474", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cf03ef83-babf-4710-ab13-ace35476b474", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cf03ef83-babf-4710-ab13-ace35476b474", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b5e13a1d-86f3-415c-9c2f-4343258a4b57", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b5e13a1d-86f3-415c-9c2f-4343258a4b57", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b5e13a1d-86f3-415c-9c2f-4343258a4b57", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b5e13a1d-86f3-415c-9c2f-4343258a4b57", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "94430690-6bd2-4e48-b0c3-4de11c7f5d81", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "94430690-6bd2-4e48-b0c3-4de11c7f5d81", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "94430690-6bd2-4e48-b0c3-4de11c7f5d81", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "94430690-6bd2-4e48-b0c3-4de11c7f5d81", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "89c5b8e4-4c60-4e08-88ad-4509be08bde4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "89c5b8e4-4c60-4e08-88ad-4509be08bde4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "89c5b8e4-4c60-4e08-88ad-4509be08bde4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "89c5b8e4-4c60-4e08-88ad-4509be08bde4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "e9ca0d20-0315-4fca-b334-e6e046cd076e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "e9ca0d20-0315-4fca-b334-e6e046cd076e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "e9ca0d20-0315-4fca-b334-e6e046cd076e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "e9ca0d20-0315-4fca-b334-e6e046cd076e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "676211f2-1f90-4059-bdf8-9e26f9a637a4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "676211f2-1f90-4059-bdf8-9e26f9a637a4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "676211f2-1f90-4059-bdf8-9e26f9a637a4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "676211f2-1f90-4059-bdf8-9e26f9a637a4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c24852f9-007d-455a-8cb5-0e2681c7a0a5", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c24852f9-007d-455a-8cb5-0e2681c7a0a5", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c24852f9-007d-455a-8cb5-0e2681c7a0a5", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c24852f9-007d-455a-8cb5-0e2681c7a0a5", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f7062df1-beb7-4814-a074-e9da66830639", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f7062df1-beb7-4814-a074-e9da66830639", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f7062df1-beb7-4814-a074-e9da66830639", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f7062df1-beb7-4814-a074-e9da66830639", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "43f658bf-a5f4-4537-a281-77dbb5ce1c27", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "43f658bf-a5f4-4537-a281-77dbb5ce1c27", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "43f658bf-a5f4-4537-a281-77dbb5ce1c27", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "43f658bf-a5f4-4537-a281-77dbb5ce1c27", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d99cdf9c-bda7-4807-b92e-34b3de2e6002", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d99cdf9c-bda7-4807-b92e-34b3de2e6002", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d99cdf9c-bda7-4807-b92e-34b3de2e6002", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d99cdf9c-bda7-4807-b92e-34b3de2e6002", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "74aa5d7a-f513-4993-b672-cdf9bb448319", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "74aa5d7a-f513-4993-b672-cdf9bb448319", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "74aa5d7a-f513-4993-b672-cdf9bb448319", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "74aa5d7a-f513-4993-b672-cdf9bb448319", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a08d4c19-059b-42bc-83db-26206735e40f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a08d4c19-059b-42bc-83db-26206735e40f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a08d4c19-059b-42bc-83db-26206735e40f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a08d4c19-059b-42bc-83db-26206735e40f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "748cbc1e-8d05-4f4f-8196-9cfb28db232c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "748cbc1e-8d05-4f4f-8196-9cfb28db232c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "748cbc1e-8d05-4f4f-8196-9cfb28db232c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "748cbc1e-8d05-4f4f-8196-9cfb28db232c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4779905b-91b3-4878-97e0-58a010668be5", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4779905b-91b3-4878-97e0-58a010668be5", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4779905b-91b3-4878-97e0-58a010668be5", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4779905b-91b3-4878-97e0-58a010668be5", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5b36c084-dce0-4ba9-ba55-613210750e27", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5b36c084-dce0-4ba9-ba55-613210750e27", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5b36c084-dce0-4ba9-ba55-613210750e27", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5b36c084-dce0-4ba9-ba55-613210750e27", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cd3167af-629a-4795-8c18-cf4f49e0a7d1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cd3167af-629a-4795-8c18-cf4f49e0a7d1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cd3167af-629a-4795-8c18-cf4f49e0a7d1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cd3167af-629a-4795-8c18-cf4f49e0a7d1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a07ed297-38cd-456e-834f-c31583eab987", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a07ed297-38cd-456e-834f-c31583eab987", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a07ed297-38cd-456e-834f-c31583eab987", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a07ed297-38cd-456e-834f-c31583eab987", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "523db500-84c9-42fa-bf24-f66e77e724e5", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "523db500-84c9-42fa-bf24-f66e77e724e5", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "523db500-84c9-42fa-bf24-f66e77e724e5", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "523db500-84c9-42fa-bf24-f66e77e724e5", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "69191d39-5c1b-4261-b0d7-48a7833e08bd", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "69191d39-5c1b-4261-b0d7-48a7833e08bd", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "69191d39-5c1b-4261-b0d7-48a7833e08bd", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "69191d39-5c1b-4261-b0d7-48a7833e08bd", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2b514c67-a65f-4c0a-86b8-5bf92a974c34", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2b514c67-a65f-4c0a-86b8-5bf92a974c34", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2b514c67-a65f-4c0a-86b8-5bf92a974c34", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2b514c67-a65f-4c0a-86b8-5bf92a974c34", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d7a31657-3101-42e7-8b97-aa6ff61d3e84", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d7a31657-3101-42e7-8b97-aa6ff61d3e84", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d7a31657-3101-42e7-8b97-aa6ff61d3e84", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d7a31657-3101-42e7-8b97-aa6ff61d3e84", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8abdfc01-6b02-4b55-93d3-eea25b17de37", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8abdfc01-6b02-4b55-93d3-eea25b17de37", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8abdfc01-6b02-4b55-93d3-eea25b17de37", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8abdfc01-6b02-4b55-93d3-eea25b17de37", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4a450a7f-5ca6-42f5-9931-e130264c8e0c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4a450a7f-5ca6-42f5-9931-e130264c8e0c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4a450a7f-5ca6-42f5-9931-e130264c8e0c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4a450a7f-5ca6-42f5-9931-e130264c8e0c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "09ff2634-4a59-46ce-94c7-8428324d789f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "09ff2634-4a59-46ce-94c7-8428324d789f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "09ff2634-4a59-46ce-94c7-8428324d789f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "09ff2634-4a59-46ce-94c7-8428324d789f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5eaed820-0af4-4157-8fea-1f58baa77661", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5eaed820-0af4-4157-8fea-1f58baa77661", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5eaed820-0af4-4157-8fea-1f58baa77661", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5eaed820-0af4-4157-8fea-1f58baa77661", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "aee09720-0d54-473a-b585-c62d6c516e68", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "aee09720-0d54-473a-b585-c62d6c516e68", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "aee09720-0d54-473a-b585-c62d6c516e68", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "aee09720-0d54-473a-b585-c62d6c516e68", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4f8cc09d-7512-44d8-a98c-3004c93031f0", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4f8cc09d-7512-44d8-a98c-3004c93031f0", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4f8cc09d-7512-44d8-a98c-3004c93031f0", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4f8cc09d-7512-44d8-a98c-3004c93031f0", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "56072689-4550-44be-987e-b08667758de4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "56072689-4550-44be-987e-b08667758de4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "56072689-4550-44be-987e-b08667758de4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "56072689-4550-44be-987e-b08667758de4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            //2.BİNDALLI VE KINA YETİŞKİN


            builder.HasData(new ProductSize { ProductId = "c8e6b9db-dbc9-4d49-a473-2c8593982b56", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c8e6b9db-dbc9-4d49-a473-2c8593982b56", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c8e6b9db-dbc9-4d49-a473-2c8593982b56", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c8e6b9db-dbc9-4d49-a473-2c8593982b56", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "31b00595-bfeb-47b6-9af3-91d117e003d4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "31b00595-bfeb-47b6-9af3-91d117e003d4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "31b00595-bfeb-47b6-9af3-91d117e003d4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "31b00595-bfeb-47b6-9af3-91d117e003d4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c99efd04-1f14-49e6-bd60-208290d057a6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c99efd04-1f14-49e6-bd60-208290d057a6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c99efd04-1f14-49e6-bd60-208290d057a6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c99efd04-1f14-49e6-bd60-208290d057a6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5f9a2c76-50a5-4e93-95c9-158ae078c357", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5f9a2c76-50a5-4e93-95c9-158ae078c357", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5f9a2c76-50a5-4e93-95c9-158ae078c357", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5f9a2c76-50a5-4e93-95c9-158ae078c357", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "81cb9635-df03-42c8-8d68-944f99de02ca", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "81cb9635-df03-42c8-8d68-944f99de02ca", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "81cb9635-df03-42c8-8d68-944f99de02ca", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "81cb9635-df03-42c8-8d68-944f99de02ca", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "976d92d5-de98-47ea-a219-26842c7f8caf", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "976d92d5-de98-47ea-a219-26842c7f8caf", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "976d92d5-de98-47ea-a219-26842c7f8caf", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "976d92d5-de98-47ea-a219-26842c7f8caf", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6183a2d7-d2c5-4828-bccb-754ce1bbb002", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6183a2d7-d2c5-4828-bccb-754ce1bbb002", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6183a2d7-d2c5-4828-bccb-754ce1bbb002", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6183a2d7-d2c5-4828-bccb-754ce1bbb002", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f43faef4-2885-42c1-9035-ccc2667d7fca", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f43faef4-2885-42c1-9035-ccc2667d7fca", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f43faef4-2885-42c1-9035-ccc2667d7fca", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f43faef4-2885-42c1-9035-ccc2667d7fca", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "fb0deebe-ca58-4eb6-ac5b-67442c846405", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "fb0deebe-ca58-4eb6-ac5b-67442c846405", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "fb0deebe-ca58-4eb6-ac5b-67442c846405", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "fb0deebe-ca58-4eb6-ac5b-67442c846405", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c15e0f9b-39be-49ff-aff8-1800116358f7", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c15e0f9b-39be-49ff-aff8-1800116358f7", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c15e0f9b-39be-49ff-aff8-1800116358f7", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c15e0f9b-39be-49ff-aff8-1800116358f7", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "04a7d241-f761-4ead-803b-1d204df7bd53", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "04a7d241-f761-4ead-803b-1d204df7bd53", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "04a7d241-f761-4ead-803b-1d204df7bd53", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "04a7d241-f761-4ead-803b-1d204df7bd53", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });



            //3. STİLİZE DANS
            //Kostüm Kiralama - Stilize Dans,Salsa ve Roman Kostümleri
            //YETİŞKİN STİLİZE DANS ve ROMAN KOSTÜMLERİ
            builder.HasData(new ProductSize { ProductId = "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4534cffd-7ed4-406c-9cee-23179740daba", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4534cffd-7ed4-406c-9cee-23179740daba", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4534cffd-7ed4-406c-9cee-23179740daba", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4534cffd-7ed4-406c-9cee-23179740daba", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "bac28c61-4b74-4193-a109-f4456c44cf67", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "bac28c61-4b74-4193-a109-f4456c44cf67", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "bac28c61-4b74-4193-a109-f4456c44cf67", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "bac28c61-4b74-4193-a109-f4456c44cf67", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "815f578a-5fd8-4c79-8446-ff236b6ffafb", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "815f578a-5fd8-4c79-8446-ff236b6ffafb", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "815f578a-5fd8-4c79-8446-ff236b6ffafb", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "815f578a-5fd8-4c79-8446-ff236b6ffafb", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a4efe1b6-e7fb-4cee-96aa-1125a3888791", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a4efe1b6-e7fb-4cee-96aa-1125a3888791", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a4efe1b6-e7fb-4cee-96aa-1125a3888791", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a4efe1b6-e7fb-4cee-96aa-1125a3888791", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d302b7f9-1306-4a95-85d4-ff189df4b527", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d302b7f9-1306-4a95-85d4-ff189df4b527", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d302b7f9-1306-4a95-85d4-ff189df4b527", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d302b7f9-1306-4a95-85d4-ff189df4b527", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "dc94da97-75b3-48b7-bfb6-d46984b5f106", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "dc94da97-75b3-48b7-bfb6-d46984b5f106", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "dc94da97-75b3-48b7-bfb6-d46984b5f106", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "dc94da97-75b3-48b7-bfb6-d46984b5f106", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3d704609-8abd-4a0a-80dd-2ee9f38a3608", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3d704609-8abd-4a0a-80dd-2ee9f38a3608", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3d704609-8abd-4a0a-80dd-2ee9f38a3608", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3d704609-8abd-4a0a-80dd-2ee9f38a3608", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "faa28a13-3b08-4a67-834d-621e4dd3d287", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "faa28a13-3b08-4a67-834d-621e4dd3d287", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "faa28a13-3b08-4a67-834d-621e4dd3d287", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "faa28a13-3b08-4a67-834d-621e4dd3d287", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8af7be7f-0ff6-40e1-b206-e89d78430393", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8af7be7f-0ff6-40e1-b206-e89d78430393", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8af7be7f-0ff6-40e1-b206-e89d78430393", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8af7be7f-0ff6-40e1-b206-e89d78430393", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "eb3e277a-61f3-4f55-b179-d474841a80a3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "eb3e277a-61f3-4f55-b179-d474841a80a3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "eb3e277a-61f3-4f55-b179-d474841a80a3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "eb3e277a-61f3-4f55-b179-d474841a80a3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });





            // KİRALIK YETİŞKİN GÖSTERİ ve TÖREN KOSTÜMLERİ   ////BU KISMIN FOTOLARI YETİŞKİN ROND TÖREN KLASÖRÜNDE
            //YETİŞKİN 4. ROND TÖREN
            // Kiralık Yıl Sonu Gösteri Kıyafetleri - Asker Kıyafeti Kiralama-Çanakkale Askeri Kıyafeti
            builder.HasData(new ProductSize { ProductId = "4c0b609e-a2cc-4477-b8d7-9fec89d49462", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4c0b609e-a2cc-4477-b8d7-9fec89d49462", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4c0b609e-a2cc-4477-b8d7-9fec89d49462", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4c0b609e-a2cc-4477-b8d7-9fec89d49462", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c8eeda2a-0260-4488-9acf-fddaee71e124", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c8eeda2a-0260-4488-9acf-fddaee71e124", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c8eeda2a-0260-4488-9acf-fddaee71e124", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c8eeda2a-0260-4488-9acf-fddaee71e124", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "7203c646-e705-48d1-8141-b2619b227d8d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7203c646-e705-48d1-8141-b2619b227d8d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7203c646-e705-48d1-8141-b2619b227d8d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7203c646-e705-48d1-8141-b2619b227d8d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0a1ff474-48a1-4366-a120-8ece6ce5ba04", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0a1ff474-48a1-4366-a120-8ece6ce5ba04", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0a1ff474-48a1-4366-a120-8ece6ce5ba04", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0a1ff474-48a1-4366-a120-8ece6ce5ba04", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cd21938d-8cdf-4c18-a25a-73a2970c2deb", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cd21938d-8cdf-4c18-a25a-73a2970c2deb", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cd21938d-8cdf-4c18-a25a-73a2970c2deb", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cd21938d-8cdf-4c18-a25a-73a2970c2deb", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8ad91c05-ccae-4482-9f43-f8f197dccdf9", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8ad91c05-ccae-4482-9f43-f8f197dccdf9", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8ad91c05-ccae-4482-9f43-f8f197dccdf9", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8ad91c05-ccae-4482-9f43-f8f197dccdf9", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6f001fcf-f1b6-4abb-8d91-7038044fabfa", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6f001fcf-f1b6-4abb-8d91-7038044fabfa", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6f001fcf-f1b6-4abb-8d91-7038044fabfa", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6f001fcf-f1b6-4abb-8d91-7038044fabfa", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "79876823-dd75-471e-b2b5-80650a4bdd47", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "79876823-dd75-471e-b2b5-80650a4bdd47", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "79876823-dd75-471e-b2b5-80650a4bdd47", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "79876823-dd75-471e-b2b5-80650a4bdd47", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "38c1edea-3339-4f95-8d4a-5f5583660d9f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "38c1edea-3339-4f95-8d4a-5f5583660d9f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "38c1edea-3339-4f95-8d4a-5f5583660d9f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "38c1edea-3339-4f95-8d4a-5f5583660d9f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            //***********************SATILIK*************************

            //HALK OYUNLARI
            //AKDENİZ,EGE,DOĞU ANADOLU,GÜNEY DOĞU,İÇ ANADOLU,KAFKAS,KARADENİZ,MARMARA,TRAKYA
            //AKDENİZ
            builder.HasData(new ProductSize { ProductId = "db5aeda4-2830-4ddd-a7ca-02363d58bf25", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "db5aeda4-2830-4ddd-a7ca-02363d58bf25", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "db5aeda4-2830-4ddd-a7ca-02363d58bf25", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "db5aeda4-2830-4ddd-a7ca-02363d58bf25", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "932c7c4b-36c5-4580-a276-a176a72fd72d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "932c7c4b-36c5-4580-a276-a176a72fd72d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "932c7c4b-36c5-4580-a276-a176a72fd72d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "932c7c4b-36c5-4580-a276-a176a72fd72d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0418ebf4-0b73-4042-a5e4-ce396d5b512b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0418ebf4-0b73-4042-a5e4-ce396d5b512b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0418ebf4-0b73-4042-a5e4-ce396d5b512b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0418ebf4-0b73-4042-a5e4-ce396d5b512b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "75ce2f59-fa25-4745-bb37-371fc11ab655", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "75ce2f59-fa25-4745-bb37-371fc11ab655", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "75ce2f59-fa25-4745-bb37-371fc11ab655", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "75ce2f59-fa25-4745-bb37-371fc11ab655", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c5381f46-f707-4fcb-8f1e-605cee507946", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c5381f46-f707-4fcb-8f1e-605cee507946", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c5381f46-f707-4fcb-8f1e-605cee507946", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c5381f46-f707-4fcb-8f1e-605cee507946", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "299be826-3901-425f-90eb-e445e73ac37c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "299be826-3901-425f-90eb-e445e73ac37c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "299be826-3901-425f-90eb-e445e73ac37c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "299be826-3901-425f-90eb-e445e73ac37c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a39041d7-3a20-4e73-9334-3fc6d8327e06", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a39041d7-3a20-4e73-9334-3fc6d8327e06", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a39041d7-3a20-4e73-9334-3fc6d8327e06", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a39041d7-3a20-4e73-9334-3fc6d8327e06", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "91cb02d4-02ee-4632-a12b-7aaa4b220344", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "91cb02d4-02ee-4632-a12b-7aaa4b220344", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "91cb02d4-02ee-4632-a12b-7aaa4b220344", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "91cb02d4-02ee-4632-a12b-7aaa4b220344", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "04c2c202-afa7-4e2c-941c-29f956783f6d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "04c2c202-afa7-4e2c-941c-29f956783f6d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "04c2c202-afa7-4e2c-941c-29f956783f6d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "04c2c202-afa7-4e2c-941c-29f956783f6d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            //EGE
            builder.HasData(new ProductSize { ProductId = "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "43c746aa-0830-449b-a594-621f04923cf6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "43c746aa-0830-449b-a594-621f04923cf6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "43c746aa-0830-449b-a594-621f04923cf6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "43c746aa-0830-449b-a594-621f04923cf6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6883361b-7a86-49b9-8fc2-90029770fe22", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6883361b-7a86-49b9-8fc2-90029770fe22", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6883361b-7a86-49b9-8fc2-90029770fe22", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6883361b-7a86-49b9-8fc2-90029770fe22", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9017f445-e420-4568-b8d9-0d84b3c46aad", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9017f445-e420-4568-b8d9-0d84b3c46aad", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9017f445-e420-4568-b8d9-0d84b3c46aad", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9017f445-e420-4568-b8d9-0d84b3c46aad", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "16b681bd-b39a-4891-ab7a-9073365bc1e7", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "16b681bd-b39a-4891-ab7a-9073365bc1e7", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "16b681bd-b39a-4891-ab7a-9073365bc1e7", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "16b681bd-b39a-4891-ab7a-9073365bc1e7", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4e99c977-d86c-48a7-8bd8-9e71d999539a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4e99c977-d86c-48a7-8bd8-9e71d999539a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4e99c977-d86c-48a7-8bd8-9e71d999539a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4e99c977-d86c-48a7-8bd8-9e71d999539a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "541a5387-302a-478d-99f2-c98f6d979aaa", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "541a5387-302a-478d-99f2-c98f6d979aaa", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "541a5387-302a-478d-99f2-c98f6d979aaa", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "541a5387-302a-478d-99f2-c98f6d979aaa", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ef08937f-96ed-443c-80ac-1f7b764d10a1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ef08937f-96ed-443c-80ac-1f7b764d10a1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ef08937f-96ed-443c-80ac-1f7b764d10a1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ef08937f-96ed-443c-80ac-1f7b764d10a1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "92a51416-05b5-47ef-834f-ad0baccbb932", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "92a51416-05b5-47ef-834f-ad0baccbb932", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "92a51416-05b5-47ef-834f-ad0baccbb932", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "92a51416-05b5-47ef-834f-ad0baccbb932", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "142730b0-0df7-430d-ab80-e750ffe0a6ba", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "142730b0-0df7-430d-ab80-e750ffe0a6ba", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "142730b0-0df7-430d-ab80-e750ffe0a6ba", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "142730b0-0df7-430d-ab80-e750ffe0a6ba", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            //DOGU ANADOLU

            builder.HasData(new ProductSize { ProductId = "eec8a34e-e0ea-4a80-bd38-c7db22f84173", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "eec8a34e-e0ea-4a80-bd38-c7db22f84173", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "eec8a34e-e0ea-4a80-bd38-c7db22f84173", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "eec8a34e-e0ea-4a80-bd38-c7db22f84173", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9377deeb-6354-4346-8d56-03b29c97d5fc", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9377deeb-6354-4346-8d56-03b29c97d5fc", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9377deeb-6354-4346-8d56-03b29c97d5fc", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9377deeb-6354-4346-8d56-03b29c97d5fc", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a907697f-9b47-4302-87f3-c4bed83b24c9", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a907697f-9b47-4302-87f3-c4bed83b24c9", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a907697f-9b47-4302-87f3-c4bed83b24c9", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a907697f-9b47-4302-87f3-c4bed83b24c9", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9f0127f0-a604-46ba-a855-ca6be06fcdb2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9f0127f0-a604-46ba-a855-ca6be06fcdb2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9f0127f0-a604-46ba-a855-ca6be06fcdb2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9f0127f0-a604-46ba-a855-ca6be06fcdb2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "958017ca-725f-4d80-b65e-79560a051a03", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "958017ca-725f-4d80-b65e-79560a051a03", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "958017ca-725f-4d80-b65e-79560a051a03", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "958017ca-725f-4d80-b65e-79560a051a03", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "39c8cf49-d75e-4703-8958-ec3bbff87723", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "39c8cf49-d75e-4703-8958-ec3bbff87723", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "39c8cf49-d75e-4703-8958-ec3bbff87723", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "39c8cf49-d75e-4703-8958-ec3bbff87723", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "39f01cd0-ae41-4070-9eb0-0f2423cc3286", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "39f01cd0-ae41-4070-9eb0-0f2423cc3286", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "39f01cd0-ae41-4070-9eb0-0f2423cc3286", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "39f01cd0-ae41-4070-9eb0-0f2423cc3286", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "7965d633-4f86-44de-8ea4-fe0c68aa6a83", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7965d633-4f86-44de-8ea4-fe0c68aa6a83", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7965d633-4f86-44de-8ea4-fe0c68aa6a83", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7965d633-4f86-44de-8ea4-fe0c68aa6a83", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "fee54746-70cf-44dd-98df-5c09bb8959a8", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "fee54746-70cf-44dd-98df-5c09bb8959a8", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "fee54746-70cf-44dd-98df-5c09bb8959a8", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "fee54746-70cf-44dd-98df-5c09bb8959a8", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6f055d63-314e-4a36-86eb-ea7e11e820c1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6f055d63-314e-4a36-86eb-ea7e11e820c1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6f055d63-314e-4a36-86eb-ea7e11e820c1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6f055d63-314e-4a36-86eb-ea7e11e820c1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            //GÜNEYDOGU anadolu

            builder.HasData(new ProductSize { ProductId = "caf33f50-8517-4995-a849-4a70bbe202f6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "caf33f50-8517-4995-a849-4a70bbe202f6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "caf33f50-8517-4995-a849-4a70bbe202f6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "caf33f50-8517-4995-a849-4a70bbe202f6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c6633a62-08d6-4613-8f06-a3fcfd76f974", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c6633a62-08d6-4613-8f06-a3fcfd76f974", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c6633a62-08d6-4613-8f06-a3fcfd76f974", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c6633a62-08d6-4613-8f06-a3fcfd76f974", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3da92c21-3bf0-4de1-a187-459271e16106", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3da92c21-3bf0-4de1-a187-459271e16106", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3da92c21-3bf0-4de1-a187-459271e16106", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3da92c21-3bf0-4de1-a187-459271e16106", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6f154805-6e66-45a6-a147-87edf4267def", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6f154805-6e66-45a6-a147-87edf4267def", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6f154805-6e66-45a6-a147-87edf4267def", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6f154805-6e66-45a6-a147-87edf4267def", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ceaa3043-fb10-4638-b942-85d7b5fc20ed", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ceaa3043-fb10-4638-b942-85d7b5fc20ed", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ceaa3043-fb10-4638-b942-85d7b5fc20ed", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ceaa3043-fb10-4638-b942-85d7b5fc20ed", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "7a7cb657-507c-4325-a047-f9d67b6fbffc", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "7a7cb657-507c-4325-a047-f9d67b6fbffc", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "7a7cb657-507c-4325-a047-f9d67b6fbffc", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "7a7cb657-507c-4325-a047-f9d67b6fbffc", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5cc37e11-afea-478b-b360-1256896a421b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5cc37e11-afea-478b-b360-1256896a421b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5cc37e11-afea-478b-b360-1256896a421b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5cc37e11-afea-478b-b360-1256896a421b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "38af7185-32ce-4cf9-95d2-52c4c4d18bce", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "38af7185-32ce-4cf9-95d2-52c4c4d18bce", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "38af7185-32ce-4cf9-95d2-52c4c4d18bce", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "38af7185-32ce-4cf9-95d2-52c4c4d18bce", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2838e6e6-1238-418a-988c-0346a2abdbc3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2838e6e6-1238-418a-988c-0346a2abdbc3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2838e6e6-1238-418a-988c-0346a2abdbc3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2838e6e6-1238-418a-988c-0346a2abdbc3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "074db959-27e0-42a0-98d9-0961864e1a7e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "074db959-27e0-42a0-98d9-0961864e1a7e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "074db959-27e0-42a0-98d9-0961864e1a7e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "074db959-27e0-42a0-98d9-0961864e1a7e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "9570f221-d5cb-4963-896f-371af0b32c79", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9570f221-d5cb-4963-896f-371af0b32c79", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9570f221-d5cb-4963-896f-371af0b32c79", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9570f221-d5cb-4963-896f-371af0b32c79", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "04886a46-180e-42d2-a3e5-86df27efaee2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "04886a46-180e-42d2-a3e5-86df27efaee2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "04886a46-180e-42d2-a3e5-86df27efaee2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "04886a46-180e-42d2-a3e5-86df27efaee2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });



            //iç anadolu

            builder.HasData(new ProductSize { ProductId = "0973a418-280f-416d-8df1-7139e28961d2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0973a418-280f-416d-8df1-7139e28961d2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0973a418-280f-416d-8df1-7139e28961d2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0973a418-280f-416d-8df1-7139e28961d2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ea59937e-0296-4758-95ad-196fce18db72", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ea59937e-0296-4758-95ad-196fce18db72", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ea59937e-0296-4758-95ad-196fce18db72", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ea59937e-0296-4758-95ad-196fce18db72", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "4b376f71-ebf0-4762-bbff-e61541afa410", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "4b376f71-ebf0-4762-bbff-e61541afa410", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "4b376f71-ebf0-4762-bbff-e61541afa410", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "4b376f71-ebf0-4762-bbff-e61541afa410", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8cefc01c-282b-4866-a0fa-238ed864481c", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" }); // Fotoğraf yok ESKİŞEHİR K3
            builder.HasData(new ProductSize { ProductId = "8cefc01c-282b-4866-a0fa-238ed864481c", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductId = "8cefc01c-282b-4866-a0fa-238ed864481c", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductId = "8cefc01c-282b-4866-a0fa-238ed864481c", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" }); // Fotoğraf yok

            builder.HasData(new ProductSize { ProductId = "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "81c921f4-7fd6-428a-aefe-648e5e11ed46", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" }); // Fotoğraf yok SİVAS K
            builder.HasData(new ProductSize { ProductId = "81c921f4-7fd6-428a-aefe-648e5e11ed46", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductId = "81c921f4-7fd6-428a-aefe-648e5e11ed46", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" }); // Fotoğraf yok
            builder.HasData(new ProductSize { ProductId = "81c921f4-7fd6-428a-aefe-648e5e11ed46", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" }); // Fotoğraf yok

            builder.HasData(new ProductSize { ProductId = "5a04a2e5-489b-4671-933a-1db0a971f40e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5a04a2e5-489b-4671-933a-1db0a971f40e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5a04a2e5-489b-4671-933a-1db0a971f40e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5a04a2e5-489b-4671-933a-1db0a971f40e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "334d6d7e-422b-4376-ac30-161f98aab66d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "334d6d7e-422b-4376-ac30-161f98aab66d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "334d6d7e-422b-4376-ac30-161f98aab66d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "334d6d7e-422b-4376-ac30-161f98aab66d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });



            //KAFKAS
            builder.HasData(new ProductSize { ProductId = "f102b409-56b3-42b4-b70c-25192033ba8d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "f102b409-56b3-42b4-b70c-25192033ba8d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "f102b409-56b3-42b4-b70c-25192033ba8d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "f102b409-56b3-42b4-b70c-25192033ba8d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "64a56e1a-be01-40b0-bc09-1fcaf2161c10", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "64a56e1a-be01-40b0-bc09-1fcaf2161c10", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "64a56e1a-be01-40b0-bc09-1fcaf2161c10", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "64a56e1a-be01-40b0-bc09-1fcaf2161c10", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c37d754a-9f08-4f13-8d26-630d896c9371", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c37d754a-9f08-4f13-8d26-630d896c9371", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c37d754a-9f08-4f13-8d26-630d896c9371", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c37d754a-9f08-4f13-8d26-630d896c9371", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "827e88a3-8580-436c-9112-02d58ca2d7d0", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "827e88a3-8580-436c-9112-02d58ca2d7d0", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "827e88a3-8580-436c-9112-02d58ca2d7d0", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "827e88a3-8580-436c-9112-02d58ca2d7d0", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ef23ec60-f223-44c4-915e-196d6b011b94", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ef23ec60-f223-44c4-915e-196d6b011b94", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ef23ec60-f223-44c4-915e-196d6b011b94", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ef23ec60-f223-44c4-915e-196d6b011b94", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2bc1e669-d825-44a8-a11c-656a8209498a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2bc1e669-d825-44a8-a11c-656a8209498a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2bc1e669-d825-44a8-a11c-656a8209498a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2bc1e669-d825-44a8-a11c-656a8209498a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8d1f8204-852a-4342-b836-767fb2b71263", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8d1f8204-852a-4342-b836-767fb2b71263", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8d1f8204-852a-4342-b836-767fb2b71263", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8d1f8204-852a-4342-b836-767fb2b71263", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            //KARADENİZ
            builder.HasData(new ProductSize { ProductId = "06c505ec-998c-46c0-9163-0188423113b3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "06c505ec-998c-46c0-9163-0188423113b3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "06c505ec-998c-46c0-9163-0188423113b3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "06c505ec-998c-46c0-9163-0188423113b3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "46c82189-5271-43ba-97aa-a7b0a7dbf126", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "46c82189-5271-43ba-97aa-a7b0a7dbf126", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "46c82189-5271-43ba-97aa-a7b0a7dbf126", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "46c82189-5271-43ba-97aa-a7b0a7dbf126", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c87ce8ae-adb7-4007-8c0e-0090d0926e2eg", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "dc91cbb3-94e1-43fe-bf92-06077cf48d87", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "dc91cbb3-94e1-43fe-bf92-06077cf48d87", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "dc91cbb3-94e1-43fe-bf92-06077cf48d87", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "dc91cbb3-94e1-43fe-bf92-06077cf48d87", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "80f38d33-7c5f-4952-809c-85af1dc69962", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "80f38d33-7c5f-4952-809c-85af1dc69962", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "80f38d33-7c5f-4952-809c-85af1dc69962", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "80f38d33-7c5f-4952-809c-85af1dc69962", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "564ea3f5-665c-45f3-85ee-e4c45d3ba362", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "564ea3f5-665c-45f3-85ee-e4c45d3ba362", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "564ea3f5-665c-45f3-85ee-e4c45d3ba362", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "564ea3f5-665c-45f3-85ee-e4c45d3ba362", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "a2a34d3f-9082-4d98-9637-2bd936e60256", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "a2a34d3f-9082-4d98-9637-2bd936e60256", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "a2a34d3f-9082-4d98-9637-2bd936e60256", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "a2a34d3f-9082-4d98-9637-2bd936e60256", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0a7149b1-6928-4099-b623-787d0201e213", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0a7149b1-6928-4099-b623-787d0201e213", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0a7149b1-6928-4099-b623-787d0201e213", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0a7149b1-6928-4099-b623-787d0201e213", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "93c17f7a-aedf-4f6d-8429-df9ff308d381", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "93c17f7a-aedf-4f6d-8429-df9ff308d381", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "93c17f7a-aedf-4f6d-8429-df9ff308d381", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "93c17f7a-aedf-4f6d-8429-df9ff308d381", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8a84a13e-c0cc-4496-81a8-f4550c5807ed", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8a84a13e-c0cc-4496-81a8-f4550c5807ed", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8a84a13e-c0cc-4496-81a8-f4550c5807ed", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8a84a13e-c0cc-4496-81a8-f4550c5807ed", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "04871b2a-5533-41da-9959-f664809887c3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "04871b2a-5533-41da-9959-f664809887c3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "04871b2a-5533-41da-9959-f664809887c3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "04871b2a-5533-41da-9959-f664809887c3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });


            //MARMARA
            builder.HasData(new ProductSize { ProductId = "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "924916c0-2ad0-493a-b544-5df45fa43152", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "924916c0-2ad0-493a-b544-5df45fa43152", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "924916c0-2ad0-493a-b544-5df45fa43152", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "924916c0-2ad0-493a-b544-5df45fa43152", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "6c4014cc-3cc2-481d-9cd6-b13c45da0908", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "6c4014cc-3cc2-481d-9cd6-b13c45da0908", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "6c4014cc-3cc2-481d-9cd6-b13c45da0908", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "6c4014cc-3cc2-481d-9cd6-b13c45da0908", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "286d76ad-723d-476b-aa84-c7a6541afe81", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "286d76ad-723d-476b-aa84-c7a6541afe81", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "286d76ad-723d-476b-aa84-c7a6541afe81", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "286d76ad-723d-476b-aa84-c7a6541afe81", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "034b18a2-33ad-4020-8d9d-5a98891d0be9", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "034b18a2-33ad-4020-8d9d-5a98891d0be9", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "034b18a2-33ad-4020-8d9d-5a98891d0be9", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "034b18a2-33ad-4020-8d9d-5a98891d0be9", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "01e005f3-0bbb-4ae2-9136-f3afe1353315", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "01e005f3-0bbb-4ae2-9136-f3afe1353315", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "01e005f3-0bbb-4ae2-9136-f3afe1353315", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "01e005f3-0bbb-4ae2-9136-f3afe1353315", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });



            //TRAKYA
            builder.HasData(new ProductSize { ProductId = "cfb34052-097c-4637-b13e-86a2bc255163", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "cfb34052-097c-4637-b13e-86a2bc255163", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "cfb34052-097c-4637-b13e-86a2bc255163", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "cfb34052-097c-4637-b13e-86a2bc255163", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "e7d54d6e-42fe-472b-b696-6642067802b3", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "e7d54d6e-42fe-472b-b696-6642067802b3", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "e7d54d6e-42fe-472b-b696-6642067802b3", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "e7d54d6e-42fe-472b-b696-6642067802b3", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "55f0346e-6b98-4a1d-99f8-463b81f6a627", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "55f0346e-6b98-4a1d-99f8-463b81f6a627", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "55f0346e-6b98-4a1d-99f8-463b81f6a627", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "55f0346e-6b98-4a1d-99f8-463b81f6a627", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "5a529282-1b91-46d6-b472-e6386b95cf5d", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "5a529282-1b91-46d6-b472-e6386b95cf5d", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "5a529282-1b91-46d6-b472-e6386b95cf5d", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "5a529282-1b91-46d6-b472-e6386b95cf5d", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c5d36e60-0945-4e35-9239-22f30c29025f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c5d36e60-0945-4e35-9239-22f30c29025f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c5d36e60-0945-4e35-9239-22f30c29025f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c5d36e60-0945-4e35-9239-22f30c29025f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "39c99f61-efbf-4f5c-b084-eac381d82049", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "39c99f61-efbf-4f5c-b084-eac381d82049", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "39c99f61-efbf-4f5c-b084-eac381d82049", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "39c99f61-efbf-4f5c-b084-eac381d82049", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "731dd6c2-2937-4d4b-8c56-63b5cf581729", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "731dd6c2-2937-4d4b-8c56-63b5cf581729", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "731dd6c2-2937-4d4b-8c56-63b5cf581729", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "731dd6c2-2937-4d4b-8c56-63b5cf581729", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "8191402a-33f8-4195-bd73-3aa71191981e", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "8191402a-33f8-4195-bd73-3aa71191981e", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "8191402a-33f8-4195-bd73-3aa71191981e", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "8191402a-33f8-4195-bd73-3aa71191981e", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "3396c18a-dcd2-4638-8827-2c7fc10d6996", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "3396c18a-dcd2-4638-8827-2c7fc10d6996", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "3396c18a-dcd2-4638-8827-2c7fc10d6996", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "3396c18a-dcd2-4638-8827-2c7fc10d6996", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "43bf1028-ea0f-439a-b940-3b81b1f4d683", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "43bf1028-ea0f-439a-b940-3b81b1f4d683", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "43bf1028-ea0f-439a-b940-3b81b1f4d683", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "43bf1028-ea0f-439a-b940-3b81b1f4d683", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "beacb4b7-e74c-45d8-b8df-60e1a2a50768", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "beacb4b7-e74c-45d8-b8df-60e1a2a50768", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "beacb4b7-e74c-45d8-b8df-60e1a2a50768g", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "beacb4b7-e74c-45d8-b8df-60e1a2a50768", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "86513d65-cf7e-49d6-bd16-94286e5d60c1", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "86513d65-cf7e-49d6-bd16-94286e5d60c1", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "86513d65-cf7e-49d6-bd16-94286e5d60c1", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "86513d65-cf7e-49d6-bd16-94286e5d60c1", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "1f4cf9f5-2976-4b5c-9428-122096bf3877", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "1f4cf9f5-2976-4b5c-9428-122096bf3877", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "1f4cf9f5-2976-4b5c-9428-122096bf3877", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "1f4cf9f5-2976-4b5c-9428-122096bf3877", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "09a2d110-7772-44cd-af5f-27fb951f0544", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "09a2d110-7772-44cd-af5f-27fb951f0544", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "09a2d110-7772-44cd-af5f-27fb951f0544", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "09a2d110-7772-44cd-af5f-27fb951f0544", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            builder.HasData(new ProductSize { ProductId = "0dddae8d-37b4-47e5-9c89-95589a3f787a", SizeNumber = 8, SizeAmount = 4, SizeId = "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });
            builder.HasData(new ProductSize { ProductId = "0dddae8d-37b4-47e5-9c89-95589a3f787a", SizeNumber = 10, SizeAmount = 5, SizeId = "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });
            builder.HasData(new ProductSize { ProductId = "0dddae8d-37b4-47e5-9c89-95589a3f787a", SizeNumber = 12, SizeAmount = 6, SizeId = "11ebdd3a-f75a-4d85-9916-220874cf8af9" });
            builder.HasData(new ProductSize { ProductId = "0dddae8d-37b4-47e5-9c89-95589a3f787a", SizeNumber = 14, SizeAmount = 7, SizeId = "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            #endregion


        }
    }
}
