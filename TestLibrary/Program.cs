using LibraryLesson;
using System;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var OnePlusTwo = MathLib.Add(1, 2);

            var ModTest = MathLib.Mod(27, -5);
            Console.WriteLine($"{ ModTest}");
        }
    }
}
