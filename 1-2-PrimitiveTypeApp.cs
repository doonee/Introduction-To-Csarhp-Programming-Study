using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharpProgramming
{
    class _1_2_PrimitiveTypeApp
    {
        public static void Main() {
            bool b;
            int i = int.MaxValue;
            uint u = uint.MaxValue;
            double d = double.MaxValue;
            b = (i != 0);
            Console.WriteLine("boolean b = " + b);
            Console.WriteLine("Max value of signed integer = " + i);
            Console.WriteLine("Max value of unsigned integer = " + u);
            Console.WriteLine("Max value of double = " + d);
        }
    }
}
