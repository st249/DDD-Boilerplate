using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Interfaces;

namespace Template.Domain.Base
{
    public abstract class AggregateRoot : IAggregateRoot
    {

    }
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
    {
        protected AggregateRoot()
        {
        }

        protected AggregateRoot(TKey id) : base(id)
        {
        }
    }
}
