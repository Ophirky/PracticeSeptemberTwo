using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberTwo
{
    internal class ExcersizeFour : Excersize
    {
        public override void ExcersizeCode()
        {
            PrintTitle("TwoDigit");
            TwoDigit();

            PrintTitle("ThreeDigit");
            ThreeDigit();
        }

        public void TwoDigit()
        {
            Console.Write("Enter a two digit number: ");
            int twoDigitNum = int.Parse(Console.ReadLine());

            int tens = twoDigitNum / 10;
            int ones = twoDigitNum % 10;

            Console.WriteLine(tens + " tens");
            Console.WriteLine(ones + " ones");
        }

        public void ThreeDigit()
        {
            Console.Write("Enter a three digit number: ");
            int threeDigitNum = int.Parse(Console.ReadLine());

            int hundreds = threeDigitNum / 100;
            int tens = (threeDigitNum % 100) / 10;
            int ones = threeDigitNum % 10;

            Console.WriteLine(hundreds + " hundreds");
            Console.WriteLine(tens + " tens");
            Console.WriteLine(ones + " ones");
        }
    }
}
