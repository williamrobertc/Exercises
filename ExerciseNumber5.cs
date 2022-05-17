using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber5
    {
        public static void Main()
        {
            Console.WriteLine("What's the temperature in Fahreinheit?");
            int temperauturaF = int.Parse(Console.ReadLine());

            int celsius = (temperauturaF - 32) * 5 / 9;

            Console.WriteLine($"The temperature in Celsius is = {celsius.ToString("F2")}");

        }
    }
}
