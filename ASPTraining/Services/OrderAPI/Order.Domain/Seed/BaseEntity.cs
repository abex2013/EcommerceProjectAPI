using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Seed
{
    public abstract class BaseEntity<T> where T : BaseAuditModel
    {
        public Guid Id { get; protected set; }//Globally Unique Identifier(w/c is data type) for Id
        public bool IsActive { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);
    }
}
