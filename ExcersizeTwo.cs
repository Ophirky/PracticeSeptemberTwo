using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberTwo
{
    internal class ExcersizeTwo : Excersize
    {
        public override void ExcersizeCode()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine($"{num1} / {num2} = result: {result}, remainder: {remainder}");
        }
    }
}
