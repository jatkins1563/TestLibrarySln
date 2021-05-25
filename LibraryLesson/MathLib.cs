using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLesson
{
    public class MathLib
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subt(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Mod(int a, int b)
        {
            return Subt(a, Mult(Div(a, b), b));
        }
    }
}
