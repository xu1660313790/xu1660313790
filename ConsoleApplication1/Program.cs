using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Operation p = new Operation();
            string a,b,n;
            Console.WriterLine("请输入式子");
            a = Convert.ToString(Console.ReadLine());
            n = Convert.ToString(Console.ReadLine());
            b = Convert.ToString(Console.ReadLine());
             p.Equals(a, b);
            int i, j,k=1,m,f=1,q,w;
            i= a.Length;
            j = b.Length;
            char[] x = a.ToCharArray();
            char[] y = b.ToCharArray();
            for (m = 0; m < i; m++)
            {
                if (x[m] < 48 || x[m] > 57)
                {
                    k = 0;
                    break;
                }
               
            }
            for (m = 0; m < j; m++)
            {
                if (y[m] < 48 || y[m] > 57)
                {
                    f = 0;
                    break;
                }
            }
            Console.WriteLine(f + k);
            if (f == 0 && k == 0)
            {
                if (n == "+")
                    Console.WriteLine("计算结果为：{0}", p.jia(a, b));
                if (n == "-")
                    p.jian(a, b);
            }
            else if (f == 1 && k == 1)
            {
                q = Convert.ToInt32(a);
                w = Convert.ToInt32(b);

            if (n == "+")
                    Console.WriteLine("计算结果为：{0}", p.JiaFa(q, w));
                if (n == "-")
                    Console.WriteLine("计算结果为：{0}", p.JianFa(q, w));
                if (n == "*")
                    Console.WriteLine("计算结果为：{0}", p.ChengFa(q, w));
                if (n == "/")
                    Console.WriteLine("计算结果为：{0}",p.ChuFa(q, w));
            }
            
               
          
            
            Console.ReadKey();
        }
    }
}
