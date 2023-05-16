﻿using System;

namespace Завдання_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            Console.WriteLine("Введіть число x:");
            int x = Convert.ToInt32(Console.ReadLine());
            double y;
            if (x > 2)
            {
                if (x < 15)
                {
                    double sum = 0;
                    for (int j = 16; j <= x; j++)
                    {
                        sum += (Math.Pow(j, 2) + 1 / j);
                    }
                    y = 10 + sum;
                }
                else
                {
                    double prod = 1;
                    for (int i = 2; i <= x; i++)
                    {
                        prod *= (Math.Pow(i, 3) / 3);
                    }
                    y = 2 * prod;
                }
            }
            else
            {
                y = 10 / 2 - x;
            }
            Console.Write("Y={y}");

        }
    }
}
