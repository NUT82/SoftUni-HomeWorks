﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Contracts
{
    public interface IRemoveCollection : ICollection
    {
        public string Remove();
    }
}
