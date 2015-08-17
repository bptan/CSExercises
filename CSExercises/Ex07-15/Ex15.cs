using System;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a 3-digit number: ");
            int original = Convert.ToInt32(Console.ReadLine());
            int hundredths = original / 100 * 100;
            int tenths = (original - hundredths) / 10 * 10;
            int ones = (original - hundredths - tenths);
            //Console.WriteLine(hundredths);
            //Console.WriteLine(tenths);
            //Console.WriteLine(ones);
            double armstrong = Math.Pow((double)hundredths / 100, 3.0)
                + Math.Pow((double)tenths/10,3.0)
                + Math.Pow((double)ones,3.0);
            if (original == armstrong)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}