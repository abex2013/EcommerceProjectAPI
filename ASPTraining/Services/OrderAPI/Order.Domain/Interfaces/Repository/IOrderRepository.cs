﻿using Order.Domain.Models;
using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Repository
{
    public interface IOrderRepository : IAsyncRepository<OrderModel>
    {
        Task<List<OrderModel>> GetByUser(string user);
    }
}
