using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharpProgramming
{
    class _1_7_EventApp
    {
        // [1] 처리하려는 이벤트 처리기를 위한 델리게이트 생성
        // C# 자체제공 System.EventHandler 사용

        // [2] 이벤트 선언
        public EventHandler MyEvent;

        // [3] 이벤트 처리기 작성
        void MyEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("안녕하세요!");
        }

        // [4] 생성자 내에서 이벤트 처리기 등록
        public _1_7_EventApp() {
            this.MyEvent += new EventHandler(MyEventHandler);
        }

        // [5] 이벤트 발생 메서드
        public void InvokeEvent() {            
            if (MyEvent != null)
            {
                MyEvent(this, null);
            }
        }

        public static void Main() {
            new _1_7_EventApp().InvokeEvent();
        }
    }
}
