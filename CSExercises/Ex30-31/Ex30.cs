using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            for(int a = 5; a <= 10000; a++)
            {
                int count = 0;
                for (int i = a - 1; i > 1; i--)
                {
                    if (a % i == 0)
                    {                        
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("{0}",a);
                }
            }
        }
    }
}
