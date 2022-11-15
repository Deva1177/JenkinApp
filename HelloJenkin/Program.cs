using System;
using Calculator;
namespace HelloJenkin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(90, 99)}");
            Console.WriteLine($"Multiply = {calc.Multiply(22, 29)}");
            Console.ReadLine();  

        }
    }
}
