using System;
using static System.Console;

namespace Slice
{
    class MainApp
    {
        static void printArray(System.Array array)
        {
            foreach(var e in array)
                Write(e);
            WriteLine();
        }

        static void Main2(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1];
            for(int i = 0; i < array.Length; i++)   
                array[i] = (char)('A'+i);
            printArray(array[..]);
            printArray(array[5..]);

            Range range_5_10 = 5..10;
            printArray(array[range_5_10]);

            Index last = ^0;
            Range range_5_last = 5..last;
            printArray(array[range_5_last]);

            printArray(array[^4..^1]);
        }
    }
}
