using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class EvenOdd
    {
        public void EOrO()
        {
            Console.WriteLine("Enter the Number to Check Even or Odd");
            int a= Convert.ToInt32(Console.ReadLine());

            if(a%2==0)
            {
                Console.WriteLine("Entered Number {0} is Even",a);
            }
            else
            {
                Console.WriteLine("Entered Number {0} is Odd",a);
            }
        }
    }
}
