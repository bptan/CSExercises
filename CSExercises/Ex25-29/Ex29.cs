using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int num, sum = 0;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i< num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }
    }
}
