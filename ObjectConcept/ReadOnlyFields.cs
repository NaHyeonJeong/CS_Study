/*using System;
using static System.Console;

namespace ObjectConcept
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
//읽기 전용 필드에는 값을 할당할 수 없음
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax)
        {
            max = newMax;
        }
    }

    class MainApp
    {
        static void Main9(string[] args)
        {
            Configuration c = new Configuration(100, 0);
        }
    }
}
*/