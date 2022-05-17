using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber1
    {
        public static void Main()
        {
            Console.WriteLine("How many students? ");
            int students = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= students; i++)
            {
                Console.WriteLine("Type the grade of the {0} student", i);
                double grades = double.Parse(Console.ReadLine());

                sum += grades;
            }

            double average = sum / students;

            Console.WriteLine("The averege is {0}", average.ToString("F2"));
        }
    }
}
