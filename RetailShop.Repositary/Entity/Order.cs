using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repositary.Entity
{
    public class Order
    {

        [Key]
        [Required]
        public Guid OrderId { get; set; }
        
        [ForeignKey (nameof(ProductId))]
        [Required]
        public Guid ProductId { get; set; }

        public int NoOfProducts { get; set; }
        public int TotalCost { get; set; }
    }
}
