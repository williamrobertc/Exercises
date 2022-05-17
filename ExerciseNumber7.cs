using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber7
    {
        public static void Main()
        {
            Console.WriteLine("How many grades would you like to add");
            int amountofstudens = int.Parse(Console.ReadLine());


            double sumUp = 0;

            for (int i = 1; i <= amountofstudens; i++)
            {
                Console.WriteLine($"Type the {i} grade of the student");
                double valuess = double.Parse(Console.ReadLine());


                sumUp += valuess;

            }

            double average = sumUp / amountofstudens;

            if (average >= 7.0)
            {
                Console.WriteLine($"congrats!!! student approved with {average}");
            }
            else
            {
                Console.WriteLine("student failed! you need to study more! average: {0} ", average);
            }


        }
    }
}
