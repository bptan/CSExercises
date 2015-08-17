using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Please input an integer: ");
            // N holds the value of the number to sqrt
            int N = Convert.ToInt32(Console.ReadLine());
            double G = r.Next(0, N);
            while (Math.Abs((G * G) - N) > 0.0001) 
            {
                G = (G + N / G) / 2;
            }
            Console.WriteLine("The squareroot of {0} is {1:0.#####}", N, G);
        }
    }
}
