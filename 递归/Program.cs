using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fac(int value)
            {
                if (value <= 1)
                    return value;
                else
                    return value * Fac(value - 1);
            }
            int number=Fac(4);
           
        }
    }
}
