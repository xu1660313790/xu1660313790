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
            int x, y;
            String n;
            Operation p = new Operation();
            Console.WriteLine("请输入计算的式子");
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToString(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            p.Equals(x, y);
            try
            {
                if (n == "+")
                    Console.WriteLine("计算结果为：{0}", p.JiaFa(x, y));
                if (n == "-")
                    Console.WriteLine("计算结果为：{0}", p.JianFa(x, y));
                if (n == "*")
                    Console.WriteLine("计算结果为：{0}", p.ChengFa(x, y));
                if (n == "/")
                    Console.WriteLine("计算结果为：{0}",p.ChuFa(x, y));
            }
            catch {
                Console.WriteLine("错误：除数不能为0");
            }
            Console.ReadKey();
        }
    }
}
