﻿using System;

namespace BasicPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wel Come to Basic Core Programs");
            while(true)
            {
                Console.WriteLine("Enter the Choice \n 1)Filp Coin\n2)Leap Year\n3)Power Of 2\n" +
                    "4)Harmonic Number\n5)Prime Factor");
                int choice= Convert.ToInt32(Console.ReadLine());
                if (choice != 0)
                {
                    switch (choice)
                    {
                        case 1:
                            FlipCoin flipcoin = new FlipCoin();
                            flipcoin.HeadTails();
                            break;
                        case 2:
                            LeapYear leapYear = new LeapYear();
                            leapYear.Year();
                            break;
                        case 3:
                            PowerOf2 powerOf2 = new PowerOf2();
                            powerOf2.pow2();
                            break;
                        case 4:
                            HarmonicNumber harmonicNumber=new HarmonicNumber();
                            harmonicNumber.Harmonic();
                            break;
                        case 5:
                            PrimeFactor primeFactor= new PrimeFactor();
                            primeFactor.Factor();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter the Correct Choice");
                }
            }
        }
    }
}
