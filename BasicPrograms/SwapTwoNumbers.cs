using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class SwapTwoNumbers
    {
        public void Swapping()
        {
            Console.WriteLine("Enetr Two Numbers to Swap");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap a is --{0} and b is--{1}", a, b);
            a = a * b; // a=50 (5*10)
            b = a / b; // b= 10 (50/10)
            a = a / b; // a= 10 (50/5)
            Console.WriteLine("After Swap a is--{0} and b is --{1}", a, b);
        }
    }
}
