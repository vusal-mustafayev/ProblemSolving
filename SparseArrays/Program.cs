using System;

namespace SparseArrays
{
    class Solution
    {

        // Complete the matchingStrings function below.
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            var array = new int[queries.Length];
            var count = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                for (int j = 0; j < strings.Length; j++)
                {
                    if (queries[i] == strings[j])
                        count++;
                }
                array[i] = count;
                count = 0;
            }

            return array;
        }

        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", res));
            Console.ReadLine();
            //textWriter.WriteLine(string.Join("\n", res));
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}