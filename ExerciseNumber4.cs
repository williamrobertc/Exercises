using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber4
    {
        public static void Main()
        {
            Console.WriteLine("What's the temperature in Celsius?");
            int temperauturaC = int.Parse(Console.ReadLine());

            int fahreinheit = (9 * temperauturaC + 160) / 5;

            Console.WriteLine($"The temperature in Fahreinheit is {fahreinheit.ToString("F2")}");

        }
    }
}
