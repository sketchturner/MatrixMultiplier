﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplier
{
    static class NumUtils
    {
        public static string DecToBin(string dec)
        {
            int val;
            if (!int.TryParse(dec, out val)) return String.Empty;
            return Convert.ToString(val, 2);
        }

        internal static int[] DecToBinArray(int A)
        {
            string tmp = Convert.ToString(A, 2);
            char[] arr = tmp.Reverse().ToArray();
            return Array.ConvertAll(arr, n => (int)Char.GetNumericValue(n));
        }
    }
}