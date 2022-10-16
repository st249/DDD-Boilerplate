﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Domain.Interfaces
{
    public interface IMayHaveModificationTime
    {
        DateTime? LastModificationTime { get; }
    }
}
