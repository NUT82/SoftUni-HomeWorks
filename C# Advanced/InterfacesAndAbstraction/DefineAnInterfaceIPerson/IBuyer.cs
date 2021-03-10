using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IBuyer : IPerson
    {
        public int Food { get; set; }

        public void BuyFood();
    }
}
