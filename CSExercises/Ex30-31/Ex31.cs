using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            // tests numbers 1 to 1000
            for (int a = 1; a <= 1000; a++)
            {
                // tests for perfect number and prints it if true
                int sum = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == a)
                {
                    Console.WriteLine("{0}",a);
                }               
            }
        }
    }
}
