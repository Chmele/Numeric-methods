using System;
using System.Collections.Generic;
using System.Text;

namespace ChMLab1
{
    class Range
    {
        private double left;
        private double right;

        Range(double l, double r)
        {
            this.Left = l;
            this.Right = r;
        }

        public double Left { get => left; set => left = value; }
        public double Right { get => right; set => right = value; }
    }
}
