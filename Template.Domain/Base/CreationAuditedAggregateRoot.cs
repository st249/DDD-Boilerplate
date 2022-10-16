using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Interfaces;

namespace Template.Domain.Base
{
    public abstract class CreationAuditedAggregateRoot : CreationAuditedEntity, ICreationAuditedAggregateRoot
    {
        protected CreationAuditedAggregateRoot(Guid id) : base(id)
        {
        }

        protected CreationAuditedAggregateRoot(Guid id, Guid creatorId) : base(id, creatorId)
        {
        }
    }
    public abstract class CreationAuditedAggregateRoot<TKey> : CreationAuditedEntity<TKey>, ICreationAuditedAggregateRoot<TKey>
    {
        protected CreationAuditedAggregateRoot(TKey id) : base(id)
        {
        }

        protected CreationAuditedAggregateRoot(TKey id, Guid creatorId) : base(id, creatorId)
        {
        }
    }
    public abstract class CreationAuditedAggregateRoot<Tkey, TUser> : CreationAuditedEntity<Tkey, TUser>, ICreationAuditedAggregateRoot<Tkey, TUser>
    {
        protected CreationAuditedAggregateRoot(Tkey id) : base(id)
        {
        }

        protected CreationAuditedAggregateRoot(Tkey id, TUser creatorId) : base(id, creatorId)
        {
        }

    }
}
