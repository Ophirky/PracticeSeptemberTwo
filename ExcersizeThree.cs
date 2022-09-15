using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberTwo
{
    internal class ExcersizeThree : Excersize
    {
        public override void ExcersizeCode()
        {
            Console.Write("Enter amount of sudents: ");
            int amountOfStudents = int.Parse(Console.ReadLine());

            Console.Write("Enter the max amount of students in each group: ");
            int maxAmountOfStudents = int.Parse(Console.ReadLine());

            int numberOfGroups = amountOfStudents / maxAmountOfStudents;
            int remaindingStudents = amountOfStudents % maxAmountOfStudents;
            int studentsMissingFromSmallGroup = maxAmountOfStudents - remaindingStudents;

            Console.WriteLine($"\nThe amount of groups is: {numberOfGroups + 1}, \n\nthe number of students in the smallest group is: {remaindingStudents}, \nthe number of students missing from the small group is: {studentsMissingFromSmallGroup}.\n\nthere are {numberOfGroups} full groups and one group with {remaindingStudents} students.");
        }
    }
}
