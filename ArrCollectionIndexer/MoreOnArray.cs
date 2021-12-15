using System;
using static System.Console;

namespace MoreOnArray
{
    class MainApp
    {
        private static bool checkPassed(int score)
        {
            return score >= 60;
        }

        private static void print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main1(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Write($"{score} ");
            WriteLine();

            Array.Sort(scores);
            Array.ForEach<int> (scores, new Action<int>(print));
            WriteLine();

            WriteLine($"Number of dimensions : {scores.Rank}");
            WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");
            WriteLine($"Linear Search : 90 is at " + $"{Array.IndexOf(scores, 90)}");
            WriteLine($"Everyone passed ? :  " + $"{Array.TrueForAll<int>(scores, checkPassed)}");

            ////////////////////////////////////////////////
            ///

            int idx = Array.FindIndex<int>(scores, (score => score < 60)); //FindIndex : 특정 조건에 부합하는 메소드를 매개변수로 받음
            scores[idx] = 61;
            WriteLine($"Everyone passed? : " + $"{Array.TrueForAll<int>(scores, checkPassed)}");

            WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");
            Array.Resize<int>(ref scores, 10); //Resize : 배열 사이즈 조정
            WriteLine("New length of scores : " + $"{scores.Length}");

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(print));
            WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(print));
            WriteLine();
        }
    }
}