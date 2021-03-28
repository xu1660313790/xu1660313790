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
                Console.WriteLine("两串相同");
            else
                Console.WriteLine("两串不相等");
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
        public string jia(string a, string b)
        {
            return (a + b);
        }
        public void jian(string a, string b) {
            int i,j;
            bool f,g;
            g = true;
            string str;
            f = a.Contains(b);
            if (f ==g)
            {
                i = a.IndexOf(b);
                j = b.Length;
                str = a.Remove(i, j);
                Console.WriteLine("计算结果为：" + str);
            }
            else
                Console.WriteLine("这两个字符串无法相减");
        }
    }
}
