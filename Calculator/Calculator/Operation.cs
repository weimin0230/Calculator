using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Operation
    {
        int number1;
        int number2;
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public int Add(int a, int b)  //加法
        {
            return a + b;
        }
        public int Sub(int a,int b)   //减法
        {
            return a - b;
        }
        public int Mul(int a, int b)   //乘法
        {
            return a * b;
        }
        public int Div(int a, int b)   //除法
        {
            return a / b;
        }
        public bool Equals(int a,int b)     //比较
        {
            if (a == b)
                return true;
            else
                return false;
        }
        public void Compare(string x)
        {
            if (x=="+")
                Console.WriteLine("{0}加{1}等于{2}",number1,number2,Add(number1,number2));
            if (x == "-")
                Console.WriteLine("{0}减{1}等于{2}", number1, number2, Sub(number1, number2));
            if (x == "*")
                Console.WriteLine("{0}乘以{1}等于{2}", number1, number2, Mul(number1, number2));
            if (x == "/")
                Console.WriteLine("{0}除以{1}等于{2}", number1, number2, Div(number1, number2));
        }
    }
}
