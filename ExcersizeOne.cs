using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberTwo
{
    internal class ExcersizeOne : Excersize
    {

        public override void ExcersizeCode()
        {
            // Ten Variables
            PrintTitle("Ten Variables");
            TenVariables();

            // Three Variables
            PrintTitle("Three Variables");
            ThreeVariables();

        }

        public void TenVariables()
        {
            // number inputs
            Console.Write("Enter a number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n4 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n5 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n6 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n7 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n8 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n9 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int n10 = int.Parse(Console.ReadLine());


            // printing the unchanged order
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{n1} {n2} {n3} {n4} {n5} {n6} {n7} {n8} {n9} {n10}");

            // changing order
            n9 += n8;
            n8 = n9 - n8;
            n9 -= n8;

            n9 += n7;
            n7 = n9 - n7;
            n9 -= n7;

            n9 += n6;
            n6 = n9 - n6;
            n9 -= n6;

            n9 += n5;
            n5 = n9 - n5;
            n9 -= n5;

            n9 += n4;
            n4 = n9 - n4;
            n9 -= n4;

            n9 += n3;
            n3 = n9 - n3;
            n9 -= n3;

            n9 += n2;
            n2 = n9 - n2;
            n9 -= n2;

            n9 += n1;
            n1 = n9 - n1;
            n9 -= n1;

            n9 += n10;
            n10 = n9 - n10;
            n9 -= n10;

            // printing the new order
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{n1} {n2} {n3} {n4} {n5} {n6} {n7} {n8} {n9} {n10}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ThreeVariables()
        {
            int n1, n2, n3;

            // inputs
            Console.Write("Enter a number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            n3 = int.Parse(Console.ReadLine());

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"{n1}, {n2}, {n3}");
            Console.ForegroundColor = ConsoleColor.White;

            n1 += n3;
            n3 = n1 - n3;
            n1 -= n3;

            n1 += n2;
            n2 = n1 - n2;
            n1 -= n2;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{n1}, {n2}, {n3}");
            Console.ForegroundColor = ConsoleColor.White;

        }

        

    }
}
