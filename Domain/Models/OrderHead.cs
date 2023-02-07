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
        [Required(ErrorMessage = "Customer Name is required")]
        [DisplayName("Customer Name")]
        [MaxLength(25)]
        public string? CustomerName { get; set; }
        [DisplayName("Address")]
        [MaxLength(150)]
        public string? Address { get; set; }
        [DisplayName("Phon Number")]
        [MaxLength(15)]
        public string? PhonNum { get; set; }
        [DisplayName("Date")]
        [MaxLength(15)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
        public ICollection<OrderDet>? OrderDet { get; set; }
    }
}
