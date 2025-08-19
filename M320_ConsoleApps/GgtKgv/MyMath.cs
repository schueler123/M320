using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GgtKgv
{
    internal class MyMath
    {
        public static int Calc_ggT(int zahl1, int zahl2)
        {

            int z;
            while (zahl2 != 0)
            {
                z = zahl1 % zahl2;
                zahl1 = zahl2;
                zahl2 = z;
            }
            return zahl1;
        }

        public static int Calc_ggT_r(int zahl1, int zahl2)
        {
            if (zahl2 == 0) return zahl1;
            return Calc_ggT_r(zahl2, zahl1 % zahl2);
        }

        public static int Calc_kgV(int zahl1, int zahl2)
        {
            return (zahl1 * zahl2) / Calc_ggT(zahl1, zahl2);
        }

        public static double ArrayMean(int[] arr)
        {
            double sum = 0;
            foreach (int x in arr) sum += x;
            return sum / arr.Length;
        }

        public static int ArrayMin(int[] arr)
        {
            int min = arr[0];
            foreach (int x in arr) if (x < min) min = x;
            return min;
        }

        public static int ArrayMax(int[] arr)
        {
            int max = arr[0];
            foreach (int x in arr) if (x > max) max = x;
            return max;
        }

        public static void Swap(ref int zahl1, ref int zahl2)
        {
            int tmp = zahl1;
            zahl1 = zahl2;
            zahl2 = tmp;
        }

    }
}
