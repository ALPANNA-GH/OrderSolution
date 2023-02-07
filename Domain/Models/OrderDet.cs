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
        [DisplayName("Item Number")]
        [Required]
        [Range(100,100000, ErrorMessage ="")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Order Number")]
        [Range(100, 100000, ErrorMessage = "")]
        public int OrderId { get; set; }
        [Required(ErrorMessage ="Item discreption is required")]
        [DisplayName("Item Discreption")]
        public string? ItemDsc { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        [DisplayName("Quantity")]
        [DefaultValue(1)]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [DisplayName("Price")]        
        public float Price { get; set; }
        [Required(ErrorMessage = "Total is required")]
        [DisplayName("Total")] 
        public float Total { get; set; }
        public OrderHead? OrderHead { get; set; }
    }
}
