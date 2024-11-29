using System;

namespace jkk
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1=int.Parse(Console.ReadLine());
            var a2=int.Parse(Console.ReadLine());
            var b1=int.Parse(Console.ReadLine());
            var b2=int.Parse(Console.ReadLine());
            var c1=int.Parse(Console.ReadLine());
            var c2=int.Parse(Console.ReadLine());
            double d = a1 * b2 - a2 * b1;
            
            var x = (c1 * b2 - c2 * b1) / d;
            var y = (a1*  c2- a2*c1) / d;
            Console.WriteLine( x);
            Console.WriteLine(y);
        }
    }
}