using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 屏蔽基类的成员
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 mc = new MyClass2();
            mc.Name(MyClass2.name);
            Console.ReadKey();
        }
    }
    public class MyBaseC
    {
        public struct MyStruct
        {
            public static int x = 100;
        }
    }
    class MyClass1
    {
        public  string name = "yh";
        public void Name(string name)
        {
            Console.WriteLine(name);
        }
    }
    class MyClass2 : MyClass1
    {
        public static new  string name = "yyh";
        
    }
}
