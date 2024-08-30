using System;
using System.Runtime.InteropServices;


namespace _007_Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            num = 0;
            Console.WriteLine($"num: {num}");

            const int CONST_NUM = 200;
            Console.WriteLine($"CONST_NUM: {CONST_NUM}");
            // CONST_NUM = 0; 에러 발생 (const 키워드로 인해 값의 변경이 불가능하다)

            const double PI = 3.14;
            {
                int number = 100;

                int num1 = number + 1;
                int num2 = number + 2;
                int num3 = number + 3;
                int num4 = number + 4;
                int num5 = number + 5;

                Console.WriteLine($"num4: {num4}");

                number = 15;
                num4 = number + 4;

                Console.WriteLine($"num4: {num4}");
            }
        }
    }
}
