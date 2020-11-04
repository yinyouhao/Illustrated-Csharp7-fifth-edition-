using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态构造函数示例
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class RandomNumberClass
    {
        private static Random RandomKey;
        static RandomNumberClass()
        {
            RandomKey = new Random();
        }
        public int GetRandomNumber()
        {
            return RandomKey.Next();
        }
    }
}
