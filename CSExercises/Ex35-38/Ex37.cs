using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a sentence: ");
            string a = Console.ReadLine();
            string[] s = a.Split(' ');

            string b = "";
            for(int i = 0; i < s.Length; i++)
            {
                
                if (s[i].Length > 1)
                {
                    s[i] = s[i].ToUpper().Substring(0, 1) + s[i].Substring(1,s[i].Length -1);
                    b = b + s[i] + " ";
                }           
            }
            Console.WriteLine(b);
        }
    }
}
