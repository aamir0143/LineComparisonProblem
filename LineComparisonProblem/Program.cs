// See https://aka.ms/new-console-template for more information
using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Line Comparison Computation Program==========");
            LineLength length = new LineLength();
            length.CalculateLength(); //Call The Methods
            Console.ReadLine();
        }
    }
}
