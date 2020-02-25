/**
O(N) time coplexity 
o(n) space complexity
*/

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
 static string isValid(string s)
        {
            var freq = new int[26];
            foreach (var c in s)
            {
                freq[c - 'a']++;
            }
            var map=new Dictionary<int,int>();
            for (int i = 0; i < freq.Length; i++)if(freq[i]!=0)
            {
                if (!map.ContainsKey(freq[i]))
                {
                    map.Add(freq[i], 1);
                }
                else map[freq[i]]++;
            }
            if (map.Count > 2) return "NO";
            int[] marrk = map.Keys.ToArray();
            int[] marrv = map.Values.ToArray();
            return (map.Count==1||Math.Abs(marrk[0] - marrk[1]) == 1 && marrv[0]==1||marrv[1]==1) ? "YES" : "NO";
        }
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
