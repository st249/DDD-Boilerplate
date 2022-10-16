using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Interfaces;

namespace Template.Domain.Base
{
    public abstract class AuditedEntity : CreationAuditedEntity, IAuditedEntity
    {
        protected AuditedEntity(Guid id) : base(id)
        {
        }

        protected AuditedEntity(Guid id, Guid creatorId) : base(id, creatorId)
        {
        }

        public Guid? LastModifierId { get; protected set; }

        public DateTime? LastModificationTime { get; protected set; }
    }

    public abstract class AuditedEntity<TKey> : CreationAuditedEntity<TKey>, IAuditedEntity<TKey>
    {
        public TKey? LastModifierId { get; protected set; }

        public DateTime? LastModificationTime { get; protected set; }
        protected AuditedEntity(TKey id) : base(id)
        {
            CreationTime = DateTime.Now;
        }
        protected AuditedEntity(TKey id, Guid creatorId) : this(id)
        {
            CreatorId = creatorId;
        }
    }

    public abstract class AuditedEntity<TKey, TUser> : CreationAuditedEntity<TKey,TUser>, IAuditedEntity<TKey, TUser>
    {
        public TUser? LastModifierId { get; protected set; }

        public DateTime? LastModificationTime { get; protected set; }

        protected AuditedEntity(TKey id) : base(id)
        {
            CreationTime = DateTime.Now;
        }
        protected AuditedEntity(TKey id, TUser creatorId) : this(id)
        {
            CreatorId = creatorId;
        }
    }
}
