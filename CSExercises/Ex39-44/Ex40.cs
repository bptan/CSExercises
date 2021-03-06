using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(SQT(i));
            }
        }

        public static double SQT(int y)
        {
            Random r = new Random();
            double G = r.Next(1, y);
            while (Math.Abs((G * G) - y) > 0.0001)
            {
                G = (G + y / G) / 2;
            }

            return G;
        }
    }
}
