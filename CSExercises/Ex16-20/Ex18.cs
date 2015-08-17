using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            char grade = ' ';
            if ((marks <= 100) && (marks >= 0))
            {
                if (marks >= 80)
                {
                    grade = 'A';
                }
                else if ((marks >= 60) && (marks <= 79))
                {
                    grade = 'B';
                }
                else if ((marks >= 40) && (marks <= 59))
                {
                    grade = 'C';
                }
                else
                {
                    grade = 'F';
                }
                Console.WriteLine("You scored {0} marks which is {1} grade", marks, grade);
            }
            else
            {
                Console.WriteLine("**Error**");
            }
        }
    }
}