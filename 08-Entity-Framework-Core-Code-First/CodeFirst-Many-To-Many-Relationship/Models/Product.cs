﻿using System.Collections.Generic;

namespace CodeFirst_Many_To_Many_Relationship.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        // Foreign Key for Product - Category : ONE-TO-MANY relationship.
        public int CategoryID { get; set; }

        // Relational Property
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
