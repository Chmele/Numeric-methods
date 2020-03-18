using ChMLab1.Interfaces;

namespace ChMLab1
{
    class NewtonMethod : NumericMethod
    {
        public NewtonMethod(double precision) : base(precision) { }

        public override double Iterate(double x, Polynom p)
        {
            return x - p.Value(x) / p.Derivative().Value(x);
        }
    }
}
