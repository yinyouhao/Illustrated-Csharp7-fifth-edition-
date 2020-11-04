using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 另一个索引器示例
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();

            Console.WriteLine("Values---T0:{0},T1:{1}", a[0], a[1]);
            a[0] = 15;
            a[1] = 20;
            Console.WriteLine("Values---T0:{0},T1:{1}", a[0], a[1]);//15 20
        }
    }
    class Class1
    {
        int Temp0;//15
        int Temp1;//20
        public int this[int index]
        {
            get
            {
                return (0 == index)
                    ? Temp0
                    : Temp1;
            }
            set
            {
                if (0 == index)
                    Temp0 = value;
                else
                    Temp1 = value;
            }
        }
    }
}
