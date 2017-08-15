using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace shoppingCartSnippet.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public int StockCount { get; set; }
    }
}