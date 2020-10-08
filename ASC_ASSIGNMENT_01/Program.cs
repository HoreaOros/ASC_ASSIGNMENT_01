﻿using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ASC_ASSIGNMENT_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Legea lui Moore indica faptul ca puterea de calcul se dubleaza la fiecare 18 luni.");
            Console.WriteLine("Acest program permite aflarea timpului ramas pana cand puterea de calcul va fi de n ori mai mare decat cea din prezent.");
            Console.Write("Introdu o valoare pentru n: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int luni = Convert.ToInt32(Math.Log2(n)) * 18;
                int ani = luni / 12;
                luni = luni % 12;
                Console.Write($"Raspuns: Puterea de calcuc va fi de {n} ori mai mare in {ani} ani si {luni} luni, ");

                DateTime thisDay = DateTime.Now;
                Console.WriteLine($"pe data de {thisDay.AddYears(ani).AddMonths(luni).ToString("dd/MM/yyyy")}.");

            } catch (FormatException e)
            {
                Console.WriteLine("Va rog sa introduceti un numar natural.");
            }


            Console.ReadKey();
        }
    }
}
