using System;
using System.Collections.Generic;
using System.Text;

namespace ChMLab1.Interfaces
{
    abstract class MatrixMethod
    {
        protected double precision;
        
        public ILogger logger;
        
        public MatrixMethod(double precision)
        {
            this.precision = precision;
            this.logger = new NullLogger();
        }

        public MatrixMethod(double precision, ILogger logger)
        {
            this.precision = precision;
            this.logger = logger;
        }

        public List<double> Seek(Matrix m, List<double> v, List<double> answers)
        {
            while (!Stop(m, v, answers))
            {
                logger.Log(answers);
                answers = Iterate(m,v,answers);
            }
            return answers;
        }
        public List<double> SeekIterations(Matrix m, List<double> v, List<double> answers, int n)
        {
            for (int i = 0; i < n; i++)
            {
                logger.Log(answers);
                answers = Iterate(m, v, answers);
            }
            return answers;
        }
        protected bool Stop(Matrix m, List<double> v, List<double> answers)
        {
            var newAnswers = new List<double>(Iterate(m,v,answers));
            for (int i = 0; i < v.Count; i++)
            {
                if (Math.Abs(answers[i]-newAnswers[i]) >= precision)
                    return false;
            }
            return true;
        }
        abstract public List<double> Iterate(Matrix m, List<double> v, List<double> answers);
    }
}
