using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface ICreationAuditedAggregateRoot : ICreationAuditedEntity, IAggregateRoot
    {

    }
    public interface ICreationAuditedAggregateRoot<TKey> : ICreationAuditedEntity<TKey>, IAggregateRoot<TKey>
    {

    }
    public interface ICreationAuditedAggregateRoot<TKey,TUser> : ICreationAuditedEntity<TKey,TUser>, IAggregateRoot<TKey>
    {

    }
}
