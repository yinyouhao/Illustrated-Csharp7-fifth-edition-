using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init value:{0}", Trivial.MyValue);
            Trivial.MyValue = 10;
            Console.WriteLine("New Value:{0}", Trivial.MyValue);
            Trivial tr = new Trivial();
            tr.PrintValue();
            Console.ReadKey();
        }
    }
    class Trivial
    {
        public static int MyValue { get; set; }

        public void PrintValue()
        {
            Console.WriteLine(MyValue);//从类的内部访问静态变量
        }
    }
}
