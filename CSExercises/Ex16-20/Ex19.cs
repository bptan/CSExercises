using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the distance travelled in km: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double dist_rounded = Math.Ceiling(distance * 10) / 10;
            double charges = 0.0;
            if (dist_rounded <= 0.5)
            {
                charges = 2.4;
            }
            else if (dist_rounded <= 9.0)
            {
                charges = 2.4 + 10 * (dist_rounded - 0.5) * 0.04;
            }
            else if(dist_rounded > 9.0)
            {
                charges = 2.4 + 10 * 8.5 * 0.04 + 10 * (dist_rounded - 9) * 0.05;
            }
            Console.WriteLine("The charges are {0:c}", charges);
        }
    }
}