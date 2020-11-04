using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 7, 1, 3 };
            for (int index = 1; index <numbers.Length-1; index++)
            {
                int position = index;
                int temp_value = numbers[index];

                while ((position > 0) && (temp_value<numbers[index]))
                {
                    numbers[position] = numbers[position - 1];
                    position = position - 1;
                }
                numbers[position] = temp_value;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
