using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int number=0;
            while (number != 88)
            {
                Console.Write("Please enter an integer: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\"Lucky you...\"");
        }
    }
}
