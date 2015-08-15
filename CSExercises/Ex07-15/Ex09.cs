using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2 * (Math.Pow(x, 2)) - 4 * x + 3;
            Console.WriteLine("The value of y is: {0:0.00}", y);
        }
    }
}
