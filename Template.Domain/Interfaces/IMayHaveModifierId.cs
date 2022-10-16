using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IMayHaveModifier
    {
        Guid? LastModifierId { get; }
    }
    public interface IMayHaveModifier<TModifier>
    {
        TModifier? LastModifierId { get; }
    }

}
