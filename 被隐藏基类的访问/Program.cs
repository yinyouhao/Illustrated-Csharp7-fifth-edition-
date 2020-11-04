using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 被隐藏基类的访问
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.ReadKey();           
        }
    }
    class JiLei
    {
        public string str = "this is the base class";
    }
    class ZiLei : JiLei
    {
        public new string str = "this is the derived class";
        public void XianShi()
        {
            Console.WriteLine(str);
            Console.WriteLine(base.str);
        }
    }
}
