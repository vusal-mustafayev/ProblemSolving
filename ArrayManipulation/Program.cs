using System;
using System.IO;

namespace ArrayManipulation
{
    class Solution
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {

            return 0;
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
            long result = arrayManipulation(n, queries);
            Console.WriteLine(result);
            Console.ReadLine();
            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}