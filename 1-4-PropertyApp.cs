using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharpProgramming
{
    class propertyClass {
        private int privateValue;
        public int PrivateValue {
            get { return privateValue; }
            set { privateValue = value; }
        }
        public void DisplayValue() {
            Console.WriteLine("출력메시지: " + privateValue);
        }

        // 최근
        // public int PrivateValue { get; set; }
    }

    class _1_4_PropertyApp
    {
        public static void Main() {
            propertyClass pc = new propertyClass();
            pc.DisplayValue();
            pc.PrivateValue = 500;
            pc.DisplayValue();
        }
    }
}
