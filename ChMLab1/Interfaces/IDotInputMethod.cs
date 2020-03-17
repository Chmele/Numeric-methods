using System;
using System.Collections.Generic;
using System.Text;
using ChMLab1.Entities;


namespace ChMLab1.Interfaces
{
    interface IDotInputMethod:INumericMethod
    {
        public double Root(Dot dot, Polynom p);
    }
}
