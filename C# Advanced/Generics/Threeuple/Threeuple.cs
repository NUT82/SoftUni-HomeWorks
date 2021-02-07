using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        public Threeuple(TFirst firstItem, TSecond secondItem, TThird thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public TFirst FirstItem { get; set; }

        public TSecond SecondItem { get; set; }

        public TThird ThirdItem { get; set; }
    }
}
