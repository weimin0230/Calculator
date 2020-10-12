using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation O = new Operation();
            Character R = new Character();
            Console.WriteLine("1.数字运算");
            Console.WriteLine("2.字符串运算");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("请输入第一个整数:");
                        O.Number1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("请输入运算符:");
                        string A = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("请输入第二个整数:");
                        O.Number2 = Convert.ToInt16(Console.ReadLine());
                        O.Compare(A);
                        if (Equals(O.Number1, O.Number2) == true)
                            Console.WriteLine("两个整数相等");
                        else
                            Console.WriteLine("两个整数不相等");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("请输入第一个字符串:");
                        R.Num1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("请输入运算符:");
                        string B = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("请输入第二个字符串:");
                        R.Num2 = Convert.ToString(Console.ReadLine());
                        R.Compare1(B);
                        break;
                    }
            }
            
        }
    }
}
