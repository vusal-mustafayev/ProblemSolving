using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArrayManipulation
{
    class Solution
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            var beg = DateTime.Now;
            var a = 0;
            var b = 0;
            var k = 0;
            var array = new long[n];
            foreach (var t in queries)
            {
                a = t[0];
                b = t[1];
                k = t[2];

                for (var j = 1; j <= n; j++)
                {
                    if (j >= a && j <= b)
                        array[j - 1] += k;
                }
            }
            var maxValue = array.Max();
            var end = DateTime.Now;
            Console.WriteLine(end - beg);
            return maxValue;
        }

        static long arrayManipulation2(int n, int[][] queries)
        {
            var beg = DateTime.Now;
            var a = 0;
            var b = 0;
            var k = 0;
            var array = new List<long>();
            for (var i = 0; i < n; i++)
                array.Add(0);
            foreach (var t in queries)
            {
                a = t[0];
                b = t[1];
                k = t[2];
                for (var j = 1; j <= n; j++)
                {
                    if (t == queries[0])
                        array.Add(0);

                    if (j >= a && j <= b)
                    {
                        array[j - 1] += k;
                    }
                }
            }

            var maxValue = array.Max();
            var end = DateTime.Now;
            Console.WriteLine(end - beg);
            return maxValue;
        }
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }
            long result = arrayManipulation2(n, queries);
            Console.WriteLine(result);
            Console.ReadLine();
            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}