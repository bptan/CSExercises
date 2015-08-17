using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            //Console.Write("Please input an integer: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int F = 1;
            //for(int i = 0; i< N; i++)
            //{
            //    F *= N - i;
            //}
            //Console.WriteLine("The factorial of {0} is {1}", N, F);

            Console.Write("Please input an integer: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int F = 1;
            for (int i = N; i > 0; i--)
            {
                F *= N + 1 - i;
            }
            Console.WriteLine("The factorial of {0} is {1}", N, F);
        }
    }
}
