using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] num = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            for (int green = 0; green < num.Length - 1; green++)
            {
                for (int red = green + 1; red < num.Length; red++)
                {
                    if (num[red] < num[green])
                    {
                        int temp = num[red];
                        num[red] = num[green];
                        num[green] = temp;
                    }
                }
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write("{0} ", num[i]);
                }
                Console.WriteLine();                    
            }
        }
    }
}
