using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Domain.Models
{
    public class OrderDetMap
    {
        public OrderDetMap(EntityTypeBuilder<OrderDet> entityBuilder)
        {
            entityBuilder.Property(e => e.Id).ValueGeneratedOnAdd();
            entityBuilder.Property(e => e.OrderId).IsRequired();
            entityBuilder.Property(e => e.ItemDsc).IsRequired();
            entityBuilder.Property(e => e.Quantity).IsRequired();
            entityBuilder.Property(e => e.Price).IsRequired();
            entityBuilder.Property(e => e.Total).IsRequired();
            entityBuilder.HasOne(e => e.OrderHead)
                .WithMany(e => e.OrderDet).HasForeignKey(e => e.OrderId);

        }
    }
}
