using System;
using static System.Console;
using StrExtension;

namespace StrExtension
{
    public static class StringExtension
    {
        public static string Append(this string myString, string appendData)
        {

            return myString + appendData;
        }
    }
}

namespace Quiz1
{
    class MainApp
    {
        static void Main12(string[] args)
        {
            WriteLine($"{"hello".Append("hi")}");
        }
    }
    
}