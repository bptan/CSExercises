using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input temperature in Centigrade: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double F = 1.8 * C + 32;
            Console.WriteLine("The temperature in Fahrenheit is: {0:0.0}", F);
        }
    }
}
