using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntroductionToCsharpProgramming
{
    class _1_9_ThreadApp
    {
        static void ThreadBody() {
            Console.WriteLine("쓰레드 몸체 실행");
        }

        public static void Main() {
            ThreadStart ts = new ThreadStart(ThreadBody);
            Thread t = new Thread(ts);
            Console.WriteLine("Start");
            t.Start();
            Console.WriteLine("End");
        }
    }
}
