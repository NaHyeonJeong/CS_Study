using System;
using System.IO;
using static System.Console;

namespace Interface
{
    //인터페이스 구현
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger //ILogger를 상속함
    {
        public ConsoleLogger()
        {

        }
        public void WriteLog(string message)
        {
            WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger //ILogger를 상속함
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true; //true : buffer가 가득 차면 버퍼 내용을 전송하고 버퍼를 지움
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Write("온도를 입력해주세요 >> ");
                string temperature = ReadLine();

                if(temperature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    class MainApp
    {
        static void Main1(string[] args)
        {
            ClimateMonitor monitor1 = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor1.start();

            ClimateMonitor monitor2 = new ClimateMonitor(new ConsoleLogger());
            monitor2.start();
        }
    }
}