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

    // Complete the countSort function below.
    static void countSort(List<List<string>> arr) {
        var res = new List<string>[arr.Count];
        for (int i = 0; i < arr.Count; i++)
        {
            var index = int.Parse(arr[i][0]);
            if (res[index] == null)
                res[index] = new List<string>();
            res[index].Add(i < arr.Count / 2 ? "-" : arr[i][1]);
        }
        var output = new StringBuilder();
        for (var i = 0; i < res.Length; i++)
            if (res[i]!=null && res[i].Any())
                output.AppendFormat("{0}{1}", output.Length > 0 ? " " : "", string.Join(" ", res[i]));
        Console.WriteLine(output.ToString());
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++) {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        countSort(arr);
    }
}
