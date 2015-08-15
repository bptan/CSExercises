using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a Double: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The squareroot of {0:0.00} is {1:0.000}", x, Math.Sqrt(x));
        }
    }
}
