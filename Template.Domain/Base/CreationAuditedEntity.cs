using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Interfaces;

namespace Template.Domain.Base
{
    public abstract class CreationAuditedEntity : Entity<Guid>, ICreationAuditedEntity
    {
        public DateTime CreationTime { get; protected set; }

        public Guid? CreatorId { get; protected set; }

        protected CreationAuditedEntity(Guid id):base(id)
        {
            CreationTime = DateTime.Now;
        }
        protected CreationAuditedEntity(Guid id,Guid creatorId) : this(id)
        {
            CreatorId = creatorId;
        }
    }
    public abstract class CreationAuditedEntity<TKey> : Entity<TKey>, ICreationAuditedEntity<TKey>
    {
        public DateTime CreationTime { get; protected set; }

        public Guid? CreatorId { get; protected set; }

        protected CreationAuditedEntity(TKey id) : base(id)
        {
            CreationTime = DateTime.Now;
        }
        protected CreationAuditedEntity(TKey id, Guid creatorId) : this(id)
        {
            CreatorId = creatorId;
        }
    }

    public abstract class CreationAuditedEntity<TKey,TUser> : Entity<TKey>, ICreationAuditedEntity<TKey,TUser>
    {
        public DateTime CreationTime { get; protected set; }

        public TUser? CreatorId { get; protected set; }

        protected CreationAuditedEntity(TKey id) : base(id)
        {
            CreationTime = DateTime.Now;
        }
        protected CreationAuditedEntity(TKey id, TUser creatorId) : this(id)
        {
            CreatorId = creatorId;
        }
    }
}
