using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ehou_TekShop.Models
{
    public class PurchaseProduct
    {
        [Key]
        [Column(Order = 1)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual Purchase Purchase { get; set; }

        public virtual Product Product { get; set; }
    }
}