using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        float res = arr.Length;
        float plus = 0;
        float minus = 0;
        float zero = 0;

        foreach (var i in arr)
        {
            if (i > 0) plus++;
            else if (i == 0) zero++;
            else minus++;
        }
        Console.WriteLine(plus / res);
        Console.WriteLine(minus / res);
        Console.WriteLine(zero / res);

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
