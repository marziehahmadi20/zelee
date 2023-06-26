using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zelee
{
    class mothalath
    {
        private double b;
        private double c;
        private double alpha;

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public double Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }
        public mothalath() { }
        public mothalath(double B,double C,double Alpha)
        {
            b = B;
            c = C;
            alpha = Alpha;
        }
        public double calc()
        {
            double rusult = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c,2) - 2 * b * Math.Cos(alpha));
            return rusult;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("alpha");
            double alpha = Convert.ToDouble(Console.ReadLine());
            mothalath ts = new mothalath(b,c,alpha);
            double res = ts.calc();
            Console.WriteLine("zelee sevom" + res);



        }
    }
}
