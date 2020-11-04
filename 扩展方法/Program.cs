using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate md = new MyDate(3, 4, 5);
            Console.WriteLine("Sum:      {0}",md.Sum());
            Console.WriteLine("Average   {0}", md.Average());
            Console.ReadKey();
        }
    }
    sealed class MyDate//定义了一个密封类
    {
        private double D1, D2, D3;//私有变量 
        public MyDate(double d1,double d2,double d3)//为私有变量赋值
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }
        public double Sum()
        {
            return D1 + D2 + D3;
        }
    }
    static class ExtendMyData//定义静态类
    {                               //this关键字+类型，使得静态字段中的方法可以通过实例访问
        public static double Average(this MyDate md)
        {
            return md.Sum() / 3;//md通过实例对静态类中的方法进行了访问
        }
    }
}
