using System;

namespace CSExercises
{
    public class Ex39
    {        
        public static long Factorial(long n)
        {
            long a = n;

            while (n > 1)
            {                
                a *= n - 1;
                n--;
            }
            return a;
        }
    }
}
