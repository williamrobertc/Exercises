using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber6
    {
        public static void Main()
        {

            Console.WriteLine("What's your height");
            double height = double.Parse((Console.ReadLine()));

            double idealWeight = (72.7 - height) - 58;

            Console.WriteLine("Your ideal weight is {0}", idealWeight);


        }
    }
}
