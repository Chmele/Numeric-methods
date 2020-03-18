﻿using System;

namespace ChMLab1.Interfaces
{
    abstract class NumericMethod
    {
        public NumericMethod(double precision)
        {
            this.precision = precision;
        }

        public double Seek(double x, Polynom p)
        {
            while (!Stop(x, p))
                x = Iterate(x, p);
            return x;
        }

        protected double precision;
        protected bool Stop(double x, Polynom p)
        {
            double x2 = Iterate(x, p);
            return precision > Math.Abs(x2 - x) ||
                   precision > Math.Abs(p.Value(x2) - p.Value(x));
        }

        protected bool Stop(double x, double x2, Polynom p)
        {
            return precision > Math.Abs(x2 - x) ||
                   precision > Math.Abs(p.Value(x2) - p.Value(x));
        }

        abstract public double Iterate(double x, Polynom p);
    }
}