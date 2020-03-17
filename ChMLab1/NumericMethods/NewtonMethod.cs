using System;
using System.Collections.Generic;
using System.Text;
using ChMLab1.Entities;
using ChMLab1.Interfaces;

namespace ChMLab1
{
    class NewtonMethod : IDotInputMethod
    {
        public int IterationCount()
        {
            return 10;
        }

        public double Root(Dot dot, Polynom p)
        {
            double x = dot.X;
            var dp = p.Derivative();
            for (int i = 0; i < IterationCount(); i++)
                x -= p.Value(x) / dp.Value(x);
            return x;
        }
    }
}
