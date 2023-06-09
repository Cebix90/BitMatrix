﻿using System;
using BitMatrixLib;
using System.Collections;
using System.Net.Http.Headers;

namespace BitMatrixType
{
    class Program
    {
        static void Main(string[] args)
        {
            // konwersja jawna z `bool[,]` na `BitMatrix`
            // dane poprawne
            string s = @"011
101
";
            bool[,] a = new bool[,] {
{ false, true, true },
{ true, false, true } };
            var m = (BitMatrix)a;
            Console.WriteLine(2 == m.NumberOfRows);
            Console.WriteLine(3 == m.NumberOfColumns);
            Console.WriteLine(s == m.ToString());
        }
    }
}
