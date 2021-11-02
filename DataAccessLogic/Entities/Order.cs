using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderLineitems = new HashSet<OrderLineitem>();
        }

        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StorefrontId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Storefront Storefront { get; set; }
        public virtual ICollection<OrderLineitem> OrderLineitems { get; set; }
    }
}
