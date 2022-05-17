using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber2
    {
        public static void Main()
        {
            Console.WriteLine("How many euros would you like to convert? ");
            double euros = double.Parse(Console.ReadLine());

            Console.WriteLine("What's the curruncy? ");
            double curruncy = double.Parse(Console.ReadLine());

            double Total = euros * curruncy;

            Console.WriteLine($"The total in reals is : {Total.ToString("F2")}");
        }
    }
}
