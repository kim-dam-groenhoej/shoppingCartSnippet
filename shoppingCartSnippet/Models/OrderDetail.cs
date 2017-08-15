﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace shoppingCartSnippet.Models
{
    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }

        [Key, Column(Order = 1)]
        public int? ProductID { get; set; }

        [ForeignKey("ProductID")]
        [Required]
        public virtual Product Product { get; set; }

        [ForeignKey("OrderID")]
        [Required]
        public Order Order { get; set; }

        public int Quanity { get; set; }
    }
}