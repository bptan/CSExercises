using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            //Random r = new Random();
            //int secretnum = r.Next(0, 10);
            //int guess;
            //int count = 0;
            //do
            //{
            //    Console.Write("Please choose a number between 0-9: ");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    count++;
            //    if (secretnum == guess)
            //    {
            //        Console.WriteLine("Good job, you took {0} times", count);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please try again");
            //    }
            //} while (secretnum != guess);

            Random r = new Random();
            int secretnum = r.Next(0, 10);
            int guess;
            int count = 0;
            do
            {
                Console.Write("Please choose a number between 0-9: ");
                guess = Convert.ToInt32(Console.ReadLine());
                count++;
                if (secretnum == guess)
                {
                    Console.WriteLine("You took {0} times", count);
                }
                if ((secretnum == guess) && (count <= 2))
                {
                    Console.WriteLine("You are a Wizard!");
                }
                else if ((secretnum == guess) && (count > 2) && (count <= 5))
                {
                    Console.WriteLine("You are a good guess");
                } 
                if (count > 5)
                {
                    Console.WriteLine("You are lousy!");
                }
                if(secretnum != guess)
                {
                    Console.WriteLine("Try again");
                }
            } while (secretnum != guess);
        }
    }
}
