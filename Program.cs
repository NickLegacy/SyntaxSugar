using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? "Is less than nine" : "greater than or equal to nine";
            Console.WriteLine (response);
        
        }
    }
}
