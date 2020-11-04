using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1[0] = "Doe";

        }
        class Employee
        {
            public string LastName;
            public string FirstName;
            public string CityOfBirth;

            public string this[int index]//索引器声明
            {
                set
                {
                    switch (index)   //set访问器声明
                    {
                        case 0:LastName = value;
                            break;
                        case 1:FirstName = value;
                            break;
                        case 2:CityOfBirth = value;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("index");
                    }
                }
                get               //get访问器声明
                {
                    switch (index)
                    {
                        case 0:return LastName;
                        case 1:return FirstName;
                        case 2:return CityOfBirth;

                        default:
                            throw new ArgumentOutOfRangeException("index");
                    }
                }
            }
        }
    }
}
