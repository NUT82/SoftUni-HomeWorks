﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IRebel : IPerson
    {
        public string Group { get; set; }
    }
}
