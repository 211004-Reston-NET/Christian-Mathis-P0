using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Storefront
    {
        public Storefront()
        {
            Lineitems = new HashSet<Lineitem>();
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int StorefrontId { get; set; }

        public virtual ICollection<Lineitem> Lineitems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
