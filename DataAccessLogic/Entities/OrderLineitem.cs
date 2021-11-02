using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class OrderLineitem
    {
        public int OrderLineitemId { get; set; }
        public int LineitemId { get; set; }
        public int OrderId { get; set; }

        public virtual Lineitem Lineitem { get; set; }
        public virtual Order Order { get; set; }
    }
}
