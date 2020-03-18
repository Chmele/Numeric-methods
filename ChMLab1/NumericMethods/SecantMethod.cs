using ChMLab1.Interfaces;
using System;

namespace ChMLab1
{
    class SecantMethod : NumericMethod
    {
        public SecantMethod(double precision) : base(precision)
        {
        }

        public override double Iterate(double x, Polynom p)
        {
            throw new NotImplementedException();
        }

        new public double Seek(double x, Polynom p)
        {
            double x2 = p.Value(x) / p.Derivative().Value(x);
            while (!Stop(x, x2, p))
            {
                var buffer = x;
                x -= (x - x2) * p.Value(x) / (p.Value(x) - p.Value(x2));
                x2 = buffer;
            }
            return x;
        }
    }
}

