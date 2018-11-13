using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharpProgramming
{
    class Stack<StackType>
    {
        private StackType[] stack = new StackType[100];
        private int sp = -1;
        public void Push(StackType element)
        {
            stack[++sp] = element;
        }
        public StackType Pop() {
            return stack[sp--];
        }
    }

    class _1_8_GenericClassApp
    {
        public static void Main() {
            Stack<int> st1 = new Stack<int>();
            st1.Push(1);
            st1.Push(2);
            st1.Push(3);
            Console.WriteLine(string.Format("{0} {1} {2}", st1.Pop(), st1.Pop(), st1.Pop()));
            Stack<double> st2 = new Stack<double>();
            st2.Push(1.5);
            st2.Push(2.5);
            st2.Push(3.5);
            Console.WriteLine(string.Format("{0} {1} {2}", st2.Pop(), st2.Pop(), st2.Pop()));
        }
    }
}
