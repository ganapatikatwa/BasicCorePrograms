using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("The the Year");
            int year =Convert.ToInt32(Console.ReadLine());
            if (year%4==0 )
            {
                Console.WriteLine("IT IS LEAP YEAR");
            }
            else
            {
                Console.WriteLine("NOT LEAP YEAR");
            }
        }
    }
}
