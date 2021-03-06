using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int max;
            int min;
            double avg;
            int total = 0;
            int x = 0; /* additional variable to keep track of index of max sales */
            int y = 0; /* additional variable to keep track of index of min sales */
            int[] sales = new int[12];
            string[] month = new string[]
            {
                "January","Febuary","March","April","May","June",
                "July","August","September","October","November","December"
            };

            for(int i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter sales for {0}: ", month[i]);
                sales[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = 0;
            for (int j = 1; j < sales.Length; j++)
            {
                if (sales[j] > sales[x])
                {
                    max = j;
                    x = j;
                }
                
            }
            Console.WriteLine("Maximum Sales in {0}", month[max]);

            min = 0;
            for (int k = 1; k < sales.Length; k++)
            {
                if (sales[k] < sales[y])
                {
                    min = k;
                    y = k;
                }

            }
            Console.WriteLine("Minimum Sales in {0}", month[min]);
            
            for (int l = 0; l < sales.Length; l++)
            {
                total += sales[l];
            }

            avg = total / 12.0;
            Console.WriteLine("Average sales is {0:0.0}", avg);
        }
    }
}
