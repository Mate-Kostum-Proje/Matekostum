﻿using Mate.Entities.Concrete;
using Mate.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mate.Entities.EntityConfig.Concrete
{
    public class OrderConfig : BaseConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.UserInfos).WithMany(p => p.OrderList).HasForeignKey(p => p.UserId).IsRequired();


        }
    }
}
