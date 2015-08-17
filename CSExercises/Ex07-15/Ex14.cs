using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("The area is {0}", area);
        }
    }
}