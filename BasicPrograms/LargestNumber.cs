using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LargestNumber
    {
        public void LargeNum()
        {
            Console.WriteLine("Findind largest Amount ThreeNumbers");
            Console.WriteLine("Enter First Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First Number {0} is Large",num1);
                }
                else
                {
                    Console.WriteLine("Thired Number {0} is Large", num3);
                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("Second Number {0} is large", num2);
            }
            else
            Console.WriteLine("Thired Number {0} is Large", num3);
        }
    }
}
