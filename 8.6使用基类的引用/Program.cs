using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6使用基类的引用
{
    class Program
    {
        static void Main(string[] args)
        {
            SonClass son = new SonClass();
            son.DisPlay();
            FatherClass father = (FatherClass)son;//将子类强制转换为父类，父类中被覆盖的函数得以显示
            father.DisPlay();
            Console.ReadKey();
        }
    }
    public class FatherClass
    {
        virtual public void DisPlay()
        {
            Console.WriteLine("This is the fatherclass");
        }
    }
    class SonClass:FatherClass
    {
        override public void DisPlay()
        {
            Console.WriteLine("This is the sonclass");
            
        }
    }
}
