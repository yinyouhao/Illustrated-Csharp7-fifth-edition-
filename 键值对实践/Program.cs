using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 键值对实践
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable vote = new Hashtable();
            int i = 1;
            
            Console.WriteLine("投票，输入out结束");
            
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "out")
                {
                    break;
                }
                else if (!vote.ContainsKey(name))
                {
                    vote[name] = 1;
                    
                }
                else
                {
                    vote[name] = (int)vote[name]+1;
                }

            }
            foreach (var item in vote.Keys)
            {
                Console.WriteLine("参选人{0}的得票数为{1}。", item, vote[item]);
            }
            Console.ReadKey();
        }
    }
}
