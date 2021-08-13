using Order.Domain.Entities;
using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Models
{
    public class OrderModel : BaseAuditModel
    {
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }
        public List<OrderItemEntity> orderItems { get; set; }
        public OrderModel()
        {

        }
    }
}
