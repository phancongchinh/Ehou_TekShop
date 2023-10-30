using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ehou_TekShop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UserId { get; set; }

        [Required]
        public int Quatity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }

    }
}