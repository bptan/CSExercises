using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine().ToLower();
            //int count = 0;
            //for (int i = 0; i < phrase.Length; i++)
            //{
            //    string r = phrase.Substring(i, 1);
            //    if (r == "a")
            //    {
            //        count++;
            //    }
            //    if (r == "e")
            //    {
            //        count++;
            //    }
            //    if (r == "i")
            //    {
            //        count++;
            //    }
            //    if (r == "o")
            //    {
            //        count++;
            //    }
            //    if (r == "u")
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Total number of vowels: {0}", count);
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            for (int j = 0; j < phrase.Length; j++)
            {
                string r = phrase.Substring(j, 1);
                if (r == "a")
                {
                    a++;
                }
                if (r == "e")
                {
                    e++;
                }
                if (r == "i")
                {
                    i++;
                }
                if (r == "o")
                {
                    o++;
                }
                if (r == "u")
                {
                    u++;
                }
            }
            Console.WriteLine("Number of a: {0}", a);
            Console.WriteLine("Number of e: {0}", e);
            Console.WriteLine("Number of i: {0}", i);
            Console.WriteLine("Number of o: {0}", o);
            Console.WriteLine("Number of u: {0}", u);
        }
    }
}
