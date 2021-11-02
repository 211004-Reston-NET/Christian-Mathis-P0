using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Lineitem
    {
        public Lineitem()
        {
            OrderLineitems = new HashSet<OrderLineitem>();
        }

        public int Quantity { get; set; }
        public int LineitemId { get; set; }
        public int ProductId { get; set; }
        public int StorefrontId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Storefront Storefront { get; set; }
        public virtual ICollection<OrderLineitem> OrderLineitems { get; set; }
    }
}
