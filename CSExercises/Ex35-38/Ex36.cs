using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //Console.Write("Please enter a word: ");
            //string word = Console.ReadLine();
            //string reverse = "";
            //for (int i = word.Length-1; i >=0; i--)
            //{
            //    reverse += word.Substring(i, 1);
            //}

            //if(reverse == word)
            //{
            //    Console.WriteLine("Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome");
            //}
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine().ToLower();
            

            char[] c = new char[] { ' ', '.', ',', '!','?' };
            string[] newword = word.Split(c);
            string notreverse = "";
            string reverse = "";
            //creates the phrase without punctuation and spaces
            for(int j = 0; j < newword.Length; j++)
            {
                notreverse += newword[j];
            }
            //reverses the newly created phrase
            for (int i = notreverse.Length - 1; i >= 0; i--)
            {
                reverse += notreverse.Substring(i, 1);
            }

            if (reverse == notreverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
