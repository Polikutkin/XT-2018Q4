﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_MasTree
{
    internal class Program
    {
        internal const char Space = ' ';
        internal const char Star = '*';

        internal static void XMasTree(int n)
        {
            for (int s = 0; s <= n; s++)
            {
                for (int i = 1; i <= s; i++)
                {
                    for (int j = 0; j < (n - s) + (s - i); j++)
                    {
                        Console.Write(Space);

                        for (int k = 0; k < i + (i - 1); k++)
                        {
                            Console.Write(Star);
                        }

                        Console.WriteLine();
                    }
                }
            }
        }

        internal static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"{Environment.NewLine}Enter the number of the triangles for the X-Mas Tree.");

                bool result = int.TryParse(Console.ReadLine(), out var num);

                if (!result || num < 1)
                {
                    Console.WriteLine("Please, enter the correct number.");
                    continue;
                }

                XMasTree(num);
            }
        }
    }
}
