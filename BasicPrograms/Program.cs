using System;

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
                    "4)Harmonic Number\n5)Prime Factor\n6)Quotient and Reminder\n7)Swap Two Numbers" +
                    "\n8)Even Or Odd\n9)Alphabet is Vowel or Consonant\n10)Largest Amoung Three Numbers");
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
                        case 6:
                            QuotientRemainder quotientRemainder=new QuotientRemainder();
                            quotientRemainder.QandR();
                            break;
                        case 7:
                            SwapTwoNumbers swapTwoNumbers=new SwapTwoNumbers();
                            swapTwoNumbers.Swapping();
                            break;
                        case 8:
                            EvenOdd evenOdd=new EvenOdd();
                            evenOdd.EOrO();
                            break;
                        case 9:
                            AlphabetVowelConsonant alphabetVowelConsonant=new AlphabetVowelConsonant();
                            alphabetVowelConsonant.VowelConsonant();
                            break;
                        case 10:
                            LargestNumber largestNumber=new LargestNumber();
                            largestNumber.LargeNum();
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
