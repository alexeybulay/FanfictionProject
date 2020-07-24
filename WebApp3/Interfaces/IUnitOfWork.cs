﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp3.Interfaces
{
    public interface IUnitOfWork
    {
        IFanfic Fanfic { get; }
        ITag Tag { get; }
        void Save();
    }
}
