using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分布方法实现
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            
        }
    }
    partial class MyClass
    {
        partial void PrintSum(int a, int b);

        public void Add(int a,int b)
        {
            PrintSum(a, b);
        }
    }
    partial class MyClass
    {
        partial void PrintSum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
