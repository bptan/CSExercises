using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
