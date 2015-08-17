using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine().ToUpper();
            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr. " + name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms. " + name);
            }
            else
            {
                Console.WriteLine("Good Morning " + name);
            }
        }
    }
}