using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Interfaces;

namespace Template.Domain.Base
{
    public abstract class Entity : IEntity
    {

    }
    public abstract class Entity<TKey> : Entity, IEntity<TKey>
    {
        public virtual TKey Id { get;protected set; }

        protected Entity()
        {

        }

        protected Entity(TKey id)
        {
            Id = id;
        }
    }

}
