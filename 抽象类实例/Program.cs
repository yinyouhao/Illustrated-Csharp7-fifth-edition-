using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类实例
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PrintStuff("This is a string.");
            mc.MyInt = 28;
            Console.WriteLine(mc.MyInt);
            Console.WriteLine("Perimeter Length:{0}", mc.PerimeterLength());
            Console.ReadKey();
        }
    }
    abstract class MyBase //抽象和非抽象成员的组合
    {
        public int SideLength = 10; //数据成员
        const int TriangleSideCount = 3;//数据成员

        abstract public void PrintStuff(string s);//抽象方法
        abstract public int MyInt { get; set; }//抽象属性 一个整数值

        public int PerimeterLength()//非抽象方法
        {
            return TriangleSideCount * SideLength;
        }
    }
    class MyClass : MyBase
    {
        public override void PrintStuff(string s)//覆盖抽象方法
        {
            Console.WriteLine(s);
        }
        private int _myInt; 
        public override int MyInt //覆盖抽象属性
        {
            get { return _myInt; }
            set { _myInt = value; }
        }
    }
}
