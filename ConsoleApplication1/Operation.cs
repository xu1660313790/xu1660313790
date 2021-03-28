using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Operation
    {
        public void Equals(int a, int b) {
            if (a == b)
                Console.WriteLine("两数相同");
            else
                Console.WriteLine("两数不相等");
        }
        public int JiaFa(int a, int b) {
                return (a + b);
        }
    
        public int JianFa(int a, int b) {
            return (a - b);
        }
        public int ChengFa(int a, int b) {
            return (a * b);
        }
        public int ChuFa(int a, int b) {
            return (a / b);
        }
    }
}
