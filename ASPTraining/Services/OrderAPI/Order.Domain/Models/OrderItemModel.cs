using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Models
{
    public class OrderItemModel : BaseAuditModel
    {
        public decimal Qty { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
    }
}
