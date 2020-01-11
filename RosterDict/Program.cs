using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RosterDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newStudentId;

            
            Console.WriteLine("Enter your students' ID Numbers (or Enter to finish):");
            do
            {

                Console.WriteLine("ID Number: ");
                string stringStudentId = Console.ReadLine();
                if (stringStudentId != "")
                {
                    newStudentId = Convert.ToInt32(stringStudentId);
                } else { newStudentId = 0; }
                
                if (newStudentId != 0)
                {
                    Console.Write("Name: ");
                    string newName = Console.ReadLine();
                    students.Add(newStudentId, newName);
                }

            }
            while (newStudentId != 0);

            //Print Roster
            //Console.WriteLine("\nClass roster:");
            //foreach (KeyValuePair<int,string> student in students)
            //{
            //   Console.WriteLine(student.Key + "  " + student.Value);
            //}
            //Console.ReadLine();
            StringBuilder roster = new StringBuilder();
            foreach (KeyValuePair<int, string> student in students)
            {
                roster.Append("ID Numer ");
                roster.Append(student.Key);
                roster.Append("   ---   Name: ");
                roster.AppendLine(student.Value);
                

            }
            Console.WriteLine(roster);
            Console.ReadLine();
        }
    }
}
