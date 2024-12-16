﻿using System.ComponentModel.DataAnnotations;
using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
	public class Product : BaseEntity
	{
		public string ProductName { get; set; }
		public string? Description { get; set; }
		public bool? IsAdult { get; set; }

		public int? UnitPriceForSale { get; set; }
		public int UnitPriceForRent { get; set; }
		public bool IsSale { get; set; }
		public int Amount { get; set; }

		public bool? Gender { get; set; }// kadın= true, erkek= false
		public string? PhotoPath { get; set; }

		[Timestamp]
		public byte[]? RowVersion { get; set; }

		public List<Size> Sizes { get; set; }
		public List<BasketDetail>? BasketDetails { get; set; }
		public List<OrderDetail>? OrderDetails { get; set; }

		public ProductCategory ProductCategories { get; set; }
		public string ProductCategoryId { get; set; }
		public ProductRegion? ProductRegions { get; set; }
		public string? ProductRegionId { get; set; }
		public ProductSubRegion? ProductSubRegions { get; set; }
		public string? ProductSubRegionId { get; set; }

	}
}
