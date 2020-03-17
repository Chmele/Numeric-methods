using System;
using System.Collections.Generic;
using System.Text;

namespace ChMLab1.Entities
{
    class Dot
    {
        double x;
        public Dot(double x)
        {
            this.x = x;
        }

        public double X { get => x; set => x = value; }
    }
}
