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
    public class OrderDet
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required,MaxLength(50)]
        public string? ItemDsc { get; set; }
        [Required, DefaultValue(1)]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float Total { get; set; }
        public OrderHead? OrderHead { get; set; }
    }
}
