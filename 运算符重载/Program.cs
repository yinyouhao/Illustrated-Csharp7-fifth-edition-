using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符重载
{
    class Program
    {
        static void Main(string[] args)
        {
            LimitedInt n1 = new LimitedInt();
            LimitedInt n2 = new LimitedInt();          

            n1.value = 10;
            n2.value = -20;

            n1 = -n1;//这两步是必不可少的
            n2 = +n2;//对+-着两个运算符号的重载是对 对象n1,n2的，不是对n1,n2的value值的，所以说不能对n1.value, n2.value使用重载的+-号

            Console.WriteLine("- ni.value={0},+n2.value={1}", n1.value, n2.value);
            Console.ReadKey();
        }
    }
    class LimitedInt//定义了一个类叫LimitedInt
    {
        public static LimitedInt operator -(LimitedInt n1)
        {
          //  LimitedInt v = new LimitedInt();
            n1.value = 0;
            return n1;
        }`
        public static LimitedInt operator +(LimitedInt n2)
        {
           // LimitedInt n = new LimitedInt();//之所以要在这里定义一个这个对象是因为
            if (n2.value>0)
            {
               // n.value = n2.value;
                return n2;
            }
            else
            {
                n2.value = -n2.value;//不知道在这里会不会使用上前面重载的-号：不会
                return n2;//
            }
        }
        public double value;
    }
}
