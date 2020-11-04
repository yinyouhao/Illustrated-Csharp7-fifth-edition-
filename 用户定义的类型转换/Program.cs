using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用户定义的类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            LimitedInt li = 500;
            int value = li;
            Console.WriteLine($"li:{li.TheValue},value:{value}");
        }
    }
    class LimitedInt
    {
        const int MaxValue = 100;
        const int MinValue = 0;

        public static implicit operator int(LimitedInt li)
        {
            return li.TheValue;
        }
        public static implicit operator LimitedInt(int x)
        {
            LimitedInt li = new LimitedInt();
            li.TheValue = x;
            return li;
        }
        private int mTheValue = 0;
        public int TheValue
        {
            get { return mTheValue; }
            set
            {
                if (value < MinValue)
                    mTheValue = 0;
                else
                    mTheValue = value > MaxValue ? MaxValue : value;
            }
        }
    }
}
