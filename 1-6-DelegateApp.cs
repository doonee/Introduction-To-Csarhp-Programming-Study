using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharpProgramming
{
    class _1_6_DelegateApp
    {
        delegate void SampleDelegate();

        class DelegateClass {
            public void DelegateMethod() {
                Console.WriteLine("저는 델리게이트 메서드 입니다.");
            }
        }

        public static void Main() {
            DelegateClass dc = new DelegateClass();
            SampleDelegate sd = new SampleDelegate(dc.DelegateMethod);
            sd();
        }
    }
}
