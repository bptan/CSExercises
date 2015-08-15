using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program reads the (x,y) coordinates of two points");
            Console.Write("Please input the x coordinate of the first point: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input the y coordinate of the first point: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input the x coordinate of the second point: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input the y coordinate of the second point: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The distance between the two points is {0:0.00}", distance);
        }
    }
}
