using System;
using System.Collections.Generic;
using System.Text;
using ChMLab1.Interfaces;

namespace ChMLab1
{
    class RelaxationMethod : NumericMethod
    {
        public RelaxationMethod(double precision) : base(precision)
        {
        }

        public override double Iterate(double x, Polynom p)
        {
            throw new NotImplementedException();
        }
    }
}
