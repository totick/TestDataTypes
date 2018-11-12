using System;

namespace TestDataTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte b = 255;
            Console.WriteLine("byte {0}, Min {1}, Max {2}", b, byte.MinValue, byte.MaxValue);
            short sh = -32768;
            Console.WriteLine("short {0}, Min {1}, Max {2}", sh, short.MinValue, short.MaxValue);
            int i = 1000000001;
            Console.WriteLine("int {0}, Min {1}, Max {2}", i, int.MinValue, int.MaxValue);
            long l = 100000000000001L;
            Console.WriteLine("long {0}, Min {1}, Max {2}", l, long.MinValue, long.MaxValue);
            float f = 1.23454f;
            Console.WriteLine("float {0}, Min {1}, Max {2}", f, float.MinValue, float.MaxValue);
            decimal d = 3.34234M;
            Console.WriteLine("decimal {0}, Min {1}, Max {2}", d, decimal.MinValue, decimal.MaxValue);
            char ch = 'Ö';
            Console.WriteLine("char {0}, Min {1}, Max {2}", ch, char.MinValue, char.MaxValue);
            var v = 12;
            Console.WriteLine("var {0}", v);
        }
    }
}
