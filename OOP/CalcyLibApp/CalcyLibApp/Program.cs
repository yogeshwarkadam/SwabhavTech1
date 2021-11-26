using AdvaitCalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcyLibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.CubeEvenNumber(2);
            Console.WriteLine("even number cube:"+c1.CubeEvenNumber(2));
            Console.ReadLine();

        }
    }
}
