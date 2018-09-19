using System;
namespace exercicio2
{
    public class Utilities
    {
        public static int readInt()
        {
            return (int)Convert.ToUInt32(Console.ReadLine());
        }

        public static bool returnBigger(int x, int y)
        {
            return x >= y;
        }

        public static float readFloat()
        {
            return (float)Convert.ToDouble(Console.ReadLine());
        }

        public static bool isModX(int number, int mod)
        {
            return (number % mod == 0);
        }
    }
}
