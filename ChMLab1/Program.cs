using System;
using System.Collections.Generic;

namespace ChMLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double epsilon = 0.001;

            var p1 = new Polynom(new List<double> { 12, 5, -6, 1 });
            var p2 = new Polynom(new List<double> { -3, -1, 3, 1 });
            var p3 = new Polynom(new List<double> { -4, -4, 1, 1 });

            var relax = new RelaxationMethod(epsilon);
            var newton = new NewtonMethod(epsilon);
            var secant = new SecantMethod(epsilon);

            Console.WriteLine(relax.Seek(-2, p1));
            Console.WriteLine(newton.Seek(2.5, p2));
            Console.WriteLine(secant.Seek(3.5, p3));
            Console.WriteLine(p3.Value(0.934));
            Console.WriteLine(p3.Derivative().Derivative().Value(0.934));
        }
    }
}
