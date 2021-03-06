using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            //Random r = new Random();
            //Console.Write("Please input an integer: ");
            //// N holds the value of the number to sqrt
            //int N = Convert.ToInt32(Console.ReadLine());
            //double G = r.Next(1, N);
            //while (Math.Abs((G * G) - N) > 0.0001) 
            //{
            //    G = (G + N / G) / 2;
            //}
            //Console.WriteLine("The squareroot of {0} is {1:0.#####}", N, G);

            double N = GetInputFromUser("Please enter a number: ");
            double G = GetARandomNumberBetween1AndN(N);
            bool status = false;

            do
            {
                status = CheckWhetherGIsTheSquareRootOfN(G, N);
                if (status == false)
                {
                    G = CalculateNewG(G, N);
                }
            } while (status == false);
            Console.WriteLine(G);
        }
        static double GetInputFromUser(string prompt)
        {
            Console.Write(prompt);
            double output = Convert.ToDouble(Console.ReadLine());
            return output;
        }
        static double GetARandomNumberBetween1AndN(double input)
        {
            Random r = new Random();
            double x = r.NextDouble(); //x is between 0 and 1
            x = x * (input - 1); //input is upperbound of range to get value
            x = x + 1; // output is 1 to input
            return x;
        }
        static bool CheckWhetherGIsTheSquareRootOfN(double a, double b)
        {
            bool result = Math.Abs((a * a) - b) < 0.00001;
            return result;
        }
        static double CalculateNewG(double G, double N)
        {
            double newG = (G + N / G) / 2;
            return newG;
        }

    }
}
