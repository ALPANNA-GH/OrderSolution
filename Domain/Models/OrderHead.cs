using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderHead
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string? CustomerName { get; set; }
        [Required, MaxLength(150)]
        public string? Address { get; set; }
        [MaxLength(15)]
        public string? PhonNum { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public ICollection<OrderDet>? OrderDet { get; set; }
    }
}
