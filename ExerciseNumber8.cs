using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber8
    {
        public static void Main()
        {
            Console.WriteLine("What's the fisrt value");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What's the second Value? ");
            int number2 = int.Parse(Console.ReadLine());

            int minus = number1 - number2;

            if (minus <= 0)
            {
                Console.WriteLine($"Total: {minus} = Negative Value");
            }
            else
            {
                Console.WriteLine("Total: {0} = Positive value", minus);
            }


        }
    }
}
