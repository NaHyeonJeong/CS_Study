using System;
using static System.Console;
/**
 * 인덱서 : 객체를 배열처럼 사용할 수 있게 함
 */
namespace Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get { return array[index]; }
            set 
            {
                if(index >= array.Length) //기존 길이보다 크거나 같으면
                {
                    Array.Resize<int>(ref array, index + 1); //배열 크기 변경 진행
                    WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int length
        {
            get { return array.Length; }
        }
    }

    class MainApp
    {
        static void Main5(string[] args)
        {
            MyList list = new MyList();
            for(int i = 0; i < 5; i++)
            {
                list[i] = i;
            }
            for(int i = 0; i < list.length; i++)
                WriteLine(list[i]);
        }
    }
}
