using Order.Domain.Models;
using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Entities
{
    public class OrderEntity : BaseEntity<OrderModel>
    {
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }
        public List<OrderItemEntity> orderItems { get; set; }

        public OrderEntity()
        {
            orderItems = new List<OrderItemEntity>();
        }
        public override OrderModel MapToModel()
        {
            throw new NotImplementedException();
        }

        public override OrderModel MapToModel(OrderModel t)
        {
            throw new NotImplementedException();
        }
    }
}
