using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IAggregateRoot : IEntity
    {

    }
    public interface IAggregateRoot<TKey> : IEntity<TKey>, IAggregateRoot
    {

    }
}
