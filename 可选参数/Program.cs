using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可选参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mc = new Program();
            int n=mc.Calc(4);
            Console.WriteLine(n);
            Console.ReadKey();
        }
        public int Calc(int a, int b = 1)
        {
            return a + b;
        }
    }
}
