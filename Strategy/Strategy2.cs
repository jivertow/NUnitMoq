using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Strategy2 : IStrategy
    {
        public int Move(Context c)
        {
            return --c.Counter;
        }
    }
}
