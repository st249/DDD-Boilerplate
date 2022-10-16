using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IAuditedEntity : ICreationAuditedEntity, IMayHaveModifier, IMayHaveModificationTime
    {

    }
    public interface IAuditedEntity<TKey> : ICreationAuditedEntity<TKey>, IMayHaveModifier<TKey>, IMayHaveModificationTime
    {

    }
    public interface IAuditedEntity<TKey,TUser> : ICreationAuditedEntity<TKey,TUser>, IMayHaveModifier<TUser>, IMayHaveModificationTime
    {

    }
}
