using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命名参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mc = new Program();
            int result = mc.Calc(c: 2, a: 1, b: 1);//命名参数
            Console.WriteLine(result);
            Console.ReadKey();
        }
        int Calc(int a, int b, int c)
        {
            return (a + b) * c;
        }

    }
}
