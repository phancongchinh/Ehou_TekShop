using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ehou_TekShop.Models
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public PurchaseState State { get; set; }

        public virtual User Customer { get; set; }
    }

    public enum PurchaseState
    {
        PENDING,
        PROCESSING,
        SHIPPING,
        DELIVERED
    }
}