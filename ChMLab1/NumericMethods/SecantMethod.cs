using System;
using System.Collections.Generic;
using System.Text;
using ChMLab1.Entities;
using ChMLab1.Interfaces;

namespace ChMLab1
{
    class SecantMethod : IDotInputMethod
    {
        public int IterationCount()
        {
            return 5;
        }

        public double Root(Dot dot, Polynom p)
        {
            double x = dot.X;
            double x2 = p.Value(x) / p.Derivative().Value(x);
            for(int i = 0; i < IterationCount(); i++)
            {
                var buffer = x;
                x -= (x - x2) * p.Value(x) / (p.Value(x) - p.Value(x2));
                x2 = buffer;
            }
            return x;
        }
    }
}

