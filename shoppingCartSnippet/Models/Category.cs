using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace shoppingCartSnippet.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int ParentID { get; set; }

        [NotMapped]
        public List<Category> ChildCategories
        {
            get
            {
                var db = new ApplicationDbContext();

                return db.Categories.Where(c => c.ParentID == this.ID).ToList();
            }
        }
    }
}