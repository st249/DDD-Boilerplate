using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Interfaces;

namespace Template.Domain.Base
{
    public abstract class AuditedAggregateRoot : AuditedEntity, IAuditedAggregateRoot
    {
        protected AuditedAggregateRoot(Guid id) : base(id)
        {
        }

        protected AuditedAggregateRoot(Guid id, Guid creatorId) : base(id, creatorId)
        {
        }
    }
    public abstract class AuditedAggregateRoot<TKey> : AuditedEntity<TKey>, IAuditedAggregateRoot<TKey>
    {
        protected AuditedAggregateRoot(TKey id) : base(id)
        {
        }

        protected AuditedAggregateRoot(TKey id, Guid creatorId) : base(id, creatorId)
        {
        }
    }
    public abstract class AuditedAggregateRoot<Tkey, TUser> : AuditedEntity<Tkey, TUser>, IAuditedAggregateRoot<Tkey, TUser>
    {
        protected AuditedAggregateRoot(Tkey id) : base(id)
        {
        }

        protected AuditedAggregateRoot(Tkey id, TUser creatorId) : base(id, creatorId)
        {
        }

    }
}
