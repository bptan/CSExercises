using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int a = number1;
            int b = number2;
            while (number1 != number2)
            {
                if (number1> number2)
                {
                    number1 = number1 - number2;
                }
                else if (number2 > number1)
                {
                    number2 = number2 - number1;
                }
            }
            Console.WriteLine("HCF: {0}\nLCM: {1}", number1,(a*b)/ number1);                          
        }
    }
}
