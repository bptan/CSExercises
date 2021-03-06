using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("-------------------------------------------------------");
            for (double num = 1, inv, sqrt, sq; num <= 10; num++)
            {
                inv = 1 / num;
                sqrt = Math.Sqrt(num);
                sq = num * num;
                Console.WriteLine("{0:0.0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}",
                    num, inv, sqrt, sq);
            }
        }
    }
}
