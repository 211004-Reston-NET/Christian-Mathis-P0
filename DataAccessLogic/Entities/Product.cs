using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Product
    {
        public Product()
        {
            Lineitems = new HashSet<Lineitem>();
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int ProductId { get; set; }

        public virtual ICollection<Lineitem> Lineitems { get; set; }
    }
}
