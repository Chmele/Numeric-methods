using System;
using System.Collections.Generic;

namespace ChMLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double epsilon = 0.001;
            var k = new double[,] {
                { 5, 2, 1, 0},
                { 1, 3, 2, 8},
                { 4, -6, 1, 0},
                { 5, 0, 3, 2} 
            };

            var v = new List<double> { 14, 65, -3, 32 };

            var k2 = new double[,] {
                { 4, 0, 1, 1},
                { 0, 3, 0, 1},
                { 1, 0, 2, 0},
                { 1, 1, 0, 5} 
            };

            var v2 = new List<double> { 11, 10, 7, 23 };

            var m = new Matrix(k);
            var m2 = new Matrix(k2);

            var answers = new List<double> { 0, 0, 0, 0 };

            var l = new ConsoleLogger();

            var jacobi = new JacobiMethod(epsilon, l);
            var gauss = new GaussMethod(epsilon, l);

            //l.Log(gauss.Seek(m, v));
            l.Log(jacobi.SeekIterations(m2, v2, answers,30));

        }
    }
}
