using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class OrderHeadMap
    {
        public OrderHeadMap(EntityTypeBuilder<OrderHead> entityBuilder)
        {
            entityBuilder.HasKey(o => o.Id);
            entityBuilder.Property(o => o.CustomerName).IsRequired();
            entityBuilder.Property(o => o.Address);
            entityBuilder.Property(o => o.PhonNum);
            entityBuilder.Property(o => o.Date).IsRequired();
            entityBuilder.ToTable("OrderHead");

        }
    }
}
