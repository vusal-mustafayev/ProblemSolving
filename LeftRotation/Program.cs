using System;
using System.Collections;
using System.Collections.Generic;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            //var newArray = Rotation(d, a);
            //for (int i = 0; i < a.Length; i++)
            //    Console.Write(newArray[i]+" ");
            var list = RotationNew(d, a);
            foreach (var item in list)
                Console.Write(item + " ");

            Console.ReadLine();
        }

        public static int[] Rotation(int k, int[] array)
        {
            int temp;
            int length = array.Length;
            for (int i = 0; i < k; i++)
            {
                temp = array[0];

                for (int j = 0; j < length - 1; j++)
                    array[j] = array[j + 1];

                array[length - 1] = temp;
            }
            return array;
        }

        public static List<int> RotationNew(int k, int[] array)
        {
            var list = new List<int>(array.Length);
            list.AddRange(array);
            for (int i = 0; i < k; i++)
            {
                var a = list[0];
                list.Remove(list[0]);
                list.Add(a);
            }
            return list;
        }
    }
}
