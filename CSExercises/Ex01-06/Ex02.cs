﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an Integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of {0} is {1}", x, x * x);
        }
    }
}
