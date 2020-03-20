using ChMLab1.Interfaces;
using System;

namespace ChMLab1
{
    class NewtonMethod : NumericMethod
    {
        public NewtonMethod(double precision) : base(precision) { }

        public override double Iterate(double x, Polynom p)
        {
            //Console.WriteLine(String.Format("|{0:F6}|{1}", x,  p.Value(x)));
            return x - p.Value(x) / p.Derivative().Value(x);
        }
    }
}
