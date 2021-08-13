﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Seed
{
    public class BaseAuditModel
    {
        public Guid Guid { get; protected set; }
        public bool IsActive { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public Guid CreatedByUser { get; protected set; }
    }
}
