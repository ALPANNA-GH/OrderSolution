using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderHead
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string? PhonNum { get; set; }
        public DateTime Date { get; set; }
        public ICollection<OrderDet>? OrderDet { get; set; }
    }
}
