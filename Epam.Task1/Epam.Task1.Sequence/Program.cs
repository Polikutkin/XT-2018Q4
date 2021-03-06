﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    internal class Program
    {
         internal static void Sequence(int n)
        {
            try
            {
                if (n < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(n), "The number less than 0.");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            for (var i = 1; i < n; i++)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine(n);
        }

        internal static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a positive integer.");

                bool isDigit = int.TryParse(Console.ReadLine(), out var data);

                if (!isDigit || data < 1)
                {
                    Console.WriteLine("Please, enter the correct data.");
                    continue;
                }

                Sequence(data);
            }
        }
    }
}
