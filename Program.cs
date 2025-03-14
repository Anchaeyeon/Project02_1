using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //나중에 입력 받을 예정
            int a, b;

            int result;

            a = 100;
            b = 50;

            result = a + b;
            Console.WriteLine(a + "+" + b + "=" + result); //연산자 : operator

            result = a - b;
            Console.WriteLine(a + "-" + b + "=" + result); //연산자 : operator

            result = a * b;
            Console.WriteLine(a + "*" + b + "=" + result); //연산자 : operator

            result = a / b;
            Console.WriteLine(a + "/" + b + "=" + result); //연산자 : operator
        }
    }
}
