using ChMLab1.Entities;
using System;
using System.Collections.Generic;

namespace ChMLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = new Polynom (new List<double> { 24, -50, 35, -10, 1 });
            var p = new Polynom(new List<double> { -9, 0, 1 });
            var s = new SecantMethod();
            Console.WriteLine(s.Root(new Dot(2), p));
            //Console.WriteLine(p.Value(0).ToString());
            //Console.WriteLine(p.Derivative());
        }
    }
}
