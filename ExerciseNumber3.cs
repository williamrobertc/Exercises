using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ExerciseNumber3
    {
        public static void Main()
        {
            Console.WriteLine("How much did you sell? ");
            double sales = double.Parse(Console.ReadLine());

            double totalSales = sales *= 0.05;

            Console.WriteLine("Total sales = {0}", totalSales);

        }
    }
}
