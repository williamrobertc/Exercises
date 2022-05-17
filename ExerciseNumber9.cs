using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber9
    {
        public static void Main()
        {

            Console.WriteLine("What's the fisrt value");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("What's the second value");
            int b = int.Parse(Console.ReadLine());

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Zero is not accepted! Please type again");
                Console.WriteLine("What's the fisrt value");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("What's the second value");
                b = int.Parse(Console.ReadLine());


            }

            int division = a / b;

            int resto = division % 2;

            Console.WriteLine(resto);


        }
    }
}
