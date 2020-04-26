using System;
using System.Collections.Generic;
using System.Text;
using ChMLab1.Interfaces;

namespace ChMLab1
{
    class GaussMethod : MatrixMethod
    {
        public GaussMethod(double precision) : base(precision) { }

        public GaussMethod(double precision, ILogger logger) : base(precision, logger) { }

        public override List<double> Iterate(SLE m, List<double> answers){return null;}

        new public List<double> Seek(SLE m, List<double> v)
        {
            for (int i = 0; i < v.Count; i++)
                m.ColNormalize(i, i);
            return v;
        }
        
    }
}
