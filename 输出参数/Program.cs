using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出参数
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a1 = null;
            int a2;

            MyMethod(out a1, out a2);
        }
        static void MyMethod(out MyClass f1,out int f2)
        {
            f1 = new MyClass();
            f1.Val = 25;
            f2 = 15;
        }
    }
    public class MyClass
    {
        public int Val = 20;
    }
}
