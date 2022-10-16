using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface ICreationAuditedEntity : IHasCreationTime, IMayHaveCreator, IEntity
    {

    }
    public interface ICreationAuditedEntity<TKey> : IHasCreationTime, IMayHaveCreator, IEntity<TKey>
    {

    }
    public interface ICreationAuditedEntity<TKey,TUser> : IHasCreationTime, IMayHaveCreator<TUser>, IEntity<TKey>
    {

    }
}
