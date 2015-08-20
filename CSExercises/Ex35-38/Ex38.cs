using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            int[] order = new int[marks.Length];

            for (int green = 0; green < marks.Length - 1; green++)
            {
                for (int red = green + 1; red < marks.Length; red++)
                {
                    if (marks[red] > marks[green])
                    {
                        int temp = marks[red];
                        marks[red] = marks[green];
                        marks[green] = temp;
                        string temp2 = names[red];
                        names[red] = names[green];
                        names[green] = temp2;
                        
                    }
                }                
            }
            Console.WriteLine("Name\tMark");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", names[i], marks[i]);
            }
            
            //sorting by alphabet
            for (int left = 0; left < names.Length - 1; left++)
            {
                for (int right = left + 1; right < names.Length; right++)
                {
                    if (names[left].CompareTo(names[right]) != -1)
                    {
                        int temp = marks[right];
                        marks[right] = marks[left];
                        marks[left] = temp;
                        string temp2 = names[right];
                        names[right] = names[left];
                        names[left] = temp2;
                    }
                }
            }
            Console.WriteLine("Name\tMark");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", names[i], marks[i]);
            }


            //for (int i = 0; i < marks.Length; i++)
            //{
            //    for(int j = i; j < marks.Length;j++)
            //    {
            //        if (marks[j] > marks[i])
            //        {
            //            order[i] = j;
                        
            //        }
            //    }                
            //}
            //for(int k = 0; k <marks.Length;k++)
            //{
            //    Console.WriteLine(order[k]);
            //}
            



        }
    }
}
