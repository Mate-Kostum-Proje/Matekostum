﻿using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
