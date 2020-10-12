using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Character
    {
        string num1;
        string num2;

        public string Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public string Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public string add()
        {
            string c = String.Concat(Num1, Num2);
            return c;
        }
        public string sub()
        {
            Regex r = new Regex(Num2);
            string num1 = r.Replace(Num1, "");
            return num1;
        }
        public void Compare1(string x)
        {
            if (x == "+")
                Console.WriteLine("{0}加{1}等于{2}", num1, num2, add());
            if (x == "-")
                Console.WriteLine("{0}减{1}等于{2}", num1, num2, sub());
        }
    }
}
