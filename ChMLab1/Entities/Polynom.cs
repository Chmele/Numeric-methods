﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChMLab1
{
    class Polynom
    {
        private List<double> coefficients = new List<double>();
        public Polynom (List<double> input)
        {
            this.coefficients = input;
        }
        public double Value (double x)
        {
            if (x == 0) return coefficients[0];
            double res = 0;
            for (int i = coefficients.Count - 1; i >= 0; --i)
            {
                res += coefficients[i];
                res *= x;
            }
            return res / x;
        }
        public Polynom Derivative()
        {
            var c =  new List<double>(coefficients);
            for(int i = 0; i < coefficients.Count; i++)
                c[i] *= i;//Умножаем степень на коэффициент
            c.RemoveAt(0);//Производная константы - 0. И он не нужен.
            return new Polynom(c);
        }
    }
}