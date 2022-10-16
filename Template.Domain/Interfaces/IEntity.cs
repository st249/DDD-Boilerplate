using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IEntity
    {

    }
    public interface IEntity<TKey> : IEntity
    {
        TKey Id { get; }
    }
}
