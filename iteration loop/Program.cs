﻿using System;

namespace iteration_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter your years of experience");
                int a = int.Parse(Console.ReadLine());
                int i = 0;
                while (i <= a)
                {

                    Console.WriteLine("You have {0} years of experinece", i);
                    i++;

                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }
    }
}
