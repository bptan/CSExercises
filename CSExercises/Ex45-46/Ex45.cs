using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int amount;
            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Convert.ToDouble(Console.ReadLine())*100);
            
            while (amount >= 100)
            {
                Console.WriteLine("100c");
                amount -= 100;
            }
            while (amount >= 50)
            {
                Console.WriteLine("50c");
                amount -= 50;
            }
            while (amount >= 20)
            {
                Console.WriteLine("20c");
                amount -= 20;
            }
            while (amount >= 10)
            {
                Console.WriteLine("10c");
                amount -= 10;
            }
            while (amount >= 5)
            {
                Console.WriteLine("5c");
                amount -= 5;
            }
        }
    }
}
