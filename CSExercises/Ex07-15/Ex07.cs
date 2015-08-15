using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            double housing = 0.1 * salary;
            double transport = 0.03 * salary;
            double total = salary + transport + housing;
            Console.WriteLine("The total income is {0:c}", total);
        }
    }
}
