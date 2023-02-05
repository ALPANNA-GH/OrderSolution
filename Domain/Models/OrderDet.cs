using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderDet
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? ItemNum { get; set; }
        public string? ItemDsc { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Total { get; set; }
        public OrderHead? OrderHead { get; set; }
    }
}
