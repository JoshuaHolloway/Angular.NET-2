//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Rating
    {
        public long RatingId { get; set; }// Primary Key

        public int Stars { get; set; } // Regular property used to store a rating from a customer

        public Product Product { get; set; } // Navigation property used to relate a Rating object to a Product object
    }
}
