using System;
using static System.Console;

namespace Annonymous
{
    delegate int Compare(int a, int b);

    class MainApp
    {
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < DataSet.Length-1; i++)
            {
                for(j = 0; j < DataSet.Length-(i+1); j++)
                {
                    if(Comparer(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j+1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main3(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            WriteLine("Sorting ascending ... ");
            BubbleSort(array, delegate(int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array.Length; i++)
                WriteLine($"{array[i]}");

            int[] array2 = { 7, 2, 8, 10, 11 };
            WriteLine("\nSorting descending ... ");
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for(int i = 0; i < array2.Length; i++)
            {
                WriteLine($"{array2[i]}");
            }
            WriteLine();

        }
    }
}
