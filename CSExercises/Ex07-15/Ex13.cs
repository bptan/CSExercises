using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the distance travelled in km: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double fare = 2.40 + distance * 0.4;
            double fare10 = fare * 10;
            double fare_ceiling = Math.Ceiling(fare10) / 10;
            Console.WriteLine("The total fare is {0:0.00}", fare_ceiling);
        }
    }
}
