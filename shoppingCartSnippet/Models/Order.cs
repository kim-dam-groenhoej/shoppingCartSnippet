using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace shoppingCartSnippet.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public decimal Total { get; set; }

        public DateTime Created { get; set; }

        [Required]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}