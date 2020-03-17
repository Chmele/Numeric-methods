using System;
using System.Collections.Generic;
using System.Text;

namespace ChMLab1.Interfaces
{
    interface IRangeInputMethod:INumericMethod
    {
        public double Root(Range range, Polynom p);
    }
}
