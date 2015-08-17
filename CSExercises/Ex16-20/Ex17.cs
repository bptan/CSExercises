using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine().ToUpper();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if ((age < 40) && (age > 0))
            {
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
            else if (age >= 40)
            {
                if (gender == "M")
                {
                    Console.WriteLine("Good Morning Uncle " + name);
                }
                else if (gender == "F")
                {
                    Console.WriteLine("Good Morning Aunty " + name);
                }
                else
                {
                    Console.WriteLine("Good Morning " + name);
                }
            }
            else
            {
                Console.WriteLine("You have entered an invalid age");
            }
        }
    }
}