using Order.Domain.Models;
using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Entities
{
    public class OrderItemEntity : BaseEntity<OrderItemModel>
    {
        public decimal Qty { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        public override OrderItemModel MapToModel()
        {
            throw new NotImplementedException();
        }

        public override OrderItemModel MapToModel(OrderItemModel t)
        {
            throw new NotImplementedException();
        }
    }
}
