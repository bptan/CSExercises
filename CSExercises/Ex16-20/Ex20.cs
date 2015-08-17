using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the quantity for TV: ");
            int quantity_TV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity for DVD: ");
            int quantity_DVD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity for MP3: ");
            int quantity_MP3 = Convert.ToInt32(Console.ReadLine());
            int price_TV = 900;
            int price_DVD = 500;
            int price_MP3 = 700;
            double orderprice_TV;
            double orderprice_DVD;
            double orderprice_MP3;

            if ((quantity_TV * price_TV > 5000) && (quantity_TV * price_TV <= 10000))
            {
                orderprice_TV = 0.9 * quantity_TV * price_TV;
            }
            else if (quantity_TV * price_TV > 10000)
            {
                orderprice_TV = 0.85 * quantity_TV * price_TV;
            }
            else
            {
                orderprice_TV = quantity_TV * price_TV;
            }
            if ((quantity_DVD * price_DVD > 5000) && (quantity_DVD * price_DVD <= 10000))
            {
                orderprice_DVD = 0.9 * quantity_DVD * price_DVD;
            }
            else if (quantity_DVD * price_DVD > 10000)
            {
                orderprice_DVD = 0.85 * quantity_DVD * price_DVD;
            }
            else
            {
                orderprice_DVD = quantity_DVD * price_DVD;
            }

            orderprice_MP3 = quantity_MP3 * price_MP3;

            Console.WriteLine("Total price for this order is ${0}",
                orderprice_TV + orderprice_DVD + orderprice_MP3);
        }
    }
}