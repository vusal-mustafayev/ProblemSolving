using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    class Result
    {
        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            var seq = new List<int>();
            var seqList = new List<List<int>>(n);
            var lastAnswer = 0;
            for (int i = 0; i < n; i++)
                seqList.Add(new List<int>());

            for (int i = 0; i < queries.Count; i++)
            {
                int index = (queries[i][1] ^ lastAnswer) % n;

                if (queries[i][0] == 1)
                    seqList[index].Add(queries[i][2]);
                else
                {
                    int k = queries[i][2] % seqList[index].Count;
                    lastAnswer = seqList[index][k];
                    seq.Add(lastAnswer);
                }
            }
            return seq;
        }

    }
}