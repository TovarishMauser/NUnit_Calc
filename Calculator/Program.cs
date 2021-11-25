using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            
            Console.WriteLine(calc.Additional(214748364, 2147483647));
        }
    }
}
