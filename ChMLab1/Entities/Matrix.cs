using System;
using System.Collections.Generic;
using System.Text;

namespace ChMLab1
{
    class Matrix
    {
        double[,] m = { };
        
        public Matrix(double[,] m )
        {
            this.m = m;
        }

        public double this[int n, int m] => this.m[n,m];

        public List<double> GetRow(int n)
        {
            var r = new List<double>();
            for(int i = 0; i < m.GetLength(0); i++)
                r.Add(m[n,i]);
            return new List<double>(r);
        }

        public void SetRow(int n, List<double> l)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                m[n, i] = l[i];
        }
        
        public void SwapRows(int n, int m)
        {
            var buf = GetRow(n);
            SetRow(n, GetRow(m));
            SetRow(m, buf);
        }

        public void DiffRows(int n, int m, double c)
        {
            var rn = GetRow(n);
            var rm = GetRow(m);
            for (int i = 0; i < rn.Count; i++)
                rm[i] -= rn[i]/c;
            SetRow(m, rm);
        }

        public void DivRow(int n, double d)
        {
            var b = GetRow(n);
            for (int i = 0; i < b.Count; i++)
                b[i] /= d;
            SetRow(n, b);
        }
        public void ColNormalize(int n, int m, List<double> l)
        {
            l[n] /= this.m[n, m];
            DivRow(n, this.m[n, m]);
            for (int i = 0; i < this.m.GetLength(0); i++)
                if (i != n)
                {
                    l[i] -= l[n] / (this.m[n, m] / this.m[i, m]);
                    DiffRows(n, i, this.m[n, m] / this.m[i, m]);
                }
        }
    }
}
