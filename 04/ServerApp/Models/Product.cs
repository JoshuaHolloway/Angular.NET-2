//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Models
{
    public class Product
    {
        // primary key
        public long ProductId { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        // Navigation Properties: used to associate a Product object with other data in the database.
        // -Objects accessed through navigation property are referred to as related data.
        public Supplier Supplier { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
