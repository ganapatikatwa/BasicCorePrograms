using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class FlipCoin
    {
        public void HeadTails()
        {
            int i;
            int headcount = 0;
            int tailscount = 0;
            //Console.WriteLine("Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("Enter the Number of time You want to Flip The Coin");
            int NumCount = Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=NumCount; i++)
            {
                Random random = new Random();
                int headortails = random.Next(0,2);
                if(headortails < 1)
                {
                    tailscount++;
                }
                else
                {
                    headcount++;
                }
            }
            Console.WriteLine("Percentage of Head and Tails");
             float perhead = headcount / NumCount * 100;
            Console.WriteLine("Percentage of Head Count is --"+perhead);
            float pertails = tailscount / NumCount * 100;
            Console.WriteLine("Percentage of Tails Count is --" + pertails);
        }
    }
}
