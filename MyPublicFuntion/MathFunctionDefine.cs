using System;
using System.Collections.Generic;
using System.Text;

namespace MyPublicFuntion
{
    public class MathFunctionDefine
    {
        public static int Range(int x, int min, int max)
        {
            return ((int)((x) < (min) ? (min) : ((x) > (max) ? (max) : (x))));
        }

        public static decimal Range(decimal x, decimal min, decimal max)
        {
            return ((decimal)((x) < (min) ? (min) : ((x) > (max) ? (max) : (x))));
        }

        public static bool IsInRange(int x, int min, int max)
        {
            return (x >= min) && (x <= max);
        }

        public static int UpRange(int x, int max)
        {
            return ((int)((x) > (max) ? (max) : (x)));
        }

        public static int DownRange(int x, int min)
        {
            return ((int)((x) < (min) ? (min) : (x)));
        }

        public static int DeadZone(int x, int min, int max, int deadval)
        {
            return ((int)((x) < (min) ? (x) : ((x) > (max) ? (x) : (deadval))));
        }

        public static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}
