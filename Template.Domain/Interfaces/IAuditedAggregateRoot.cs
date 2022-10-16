using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IAuditedAggregateRoot : IAuditedEntity, IAggregateRoot
    {

    }
    public interface IAuditedAggregateRoot<TKey> : IAuditedEntity<TKey>, IAggregateRoot
    {

    }
    public interface IAuditedAggregateRoot<TKey, TUser> : IAuditedEntity<TKey, TUser>, IAggregateRoot
    {

    }
}
