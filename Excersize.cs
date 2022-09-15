using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberTwo
{
    internal abstract class Excersize
    {
        public Excersize()
        {
            ExcersizeCode();
        }

        public virtual void ExcersizeCode()
        {

        }

        public static void PrintTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{title}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
