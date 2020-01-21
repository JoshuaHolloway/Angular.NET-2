//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Supplier
    {
        public long SupplierId { get; set; }
        // provides the primary key when data is stored in the database

        public string Name { get; set; } // regular property

        public string City { get; set; } // regular property

        public string State { get; set; } // regular property

        // Products property is a navigation property used to move through the related data in the database.
        public IEnumerable<Product> Product { get; set; }
    }
}
