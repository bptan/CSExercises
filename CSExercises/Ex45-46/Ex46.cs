using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] random = new int[50];
            Random r = new Random();
            for (int i = 0; i < random.Length; i++)
            {                
                int a = r.Next(0, 10);
                random[i] = a;
            }
            
            for (int j = 0; j < random.Length; j++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (random[j] == k)
                    {
                        arr[k]++;
                    }
                }                                                    
            }
            //Console.WriteLine("Number\tCount");
            //for (int l = 0; l < arr.Length; l++)
            //{
            //    Console.WriteLine("{0}\t{1}",l,arr[l]);
            //}
            Console.WriteLine("Number");
            for (int l = 0; l < arr.Length; l++)
            {
                Console.Write("{0}\t", l);
                for (int i = 0; i < arr[l]; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
