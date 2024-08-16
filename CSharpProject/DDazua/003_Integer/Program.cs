﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a, b, c;

            // 정수 선언 기초
            {
                Console.WriteLine("정수 선언 기초");
                x = 1;
                a = 20;
                b = 30;
                c = 40;

                Console.WriteLine("x" + x);
                Console.WriteLine($"a: {a}");
                Console.WriteLine("b: {0}", b);
                Console.WriteLine("{0}: {1}", "c", c);
            }

            // 정수 리터럴
            {
                Console.WriteLine("\n정수 리터럴");

                a = 10;
                b = 0b10;
                c = 0x10;

                Console.WriteLine($"a: {a}");
                Console.WriteLine($"b: {b}");
                Console.WriteLine($"c: {c}");
            }

            // 정수 타입 크기
            {
                Console.WriteLine("\n정수 타입 크기");

                Console.WriteLine($"Typeof {typeof(int)} Sizeof {sizeof(int)} byte");
                Console.WriteLine($"Typeof {typeof(short)} Sizeof {sizeof(short)} byte");
                Console.WriteLine($"Typeof {typeof(long)} Sizeof {sizeof(long)} byte");

                int num = 0;
                uint uNum = 0U; // 접미사(U, u)
                short sNum = 0; 
                long lNum = 0L; // 접미사(L, l)
                ulong ulNum = 0UL; // 접미사(UL, ul)

                Console.WriteLine($"num: {num}");
                Console.WriteLine($"uNum: {uNum}");
                Console.WriteLine($"sNum: {sNum}");
                Console.WriteLine($"lNum: {lNum}");
                Console.WriteLine($"ulNum: {ulNum}");
            }

            // 저장 가능 범위
            {
                Console.WriteLine("\n저장 가능 범위");

                int maxValue = int.MaxValue;
                int minValue = int.MinValue;

                Console.WriteLine($"maxValue: {maxValue}");
                Console.WriteLine($"minValue: {minValue}");
            }

            // 캐스팅(변환)
            {
                Console.WriteLine("\n캐스팅(변환)");

                int num = 123456;
                long lNum = num;
                short sNum = (short)num;

                Console.WriteLine($"num: {num} => lNum: {lNum}");
                Console.WriteLine($"num: {num} => sNum: {sNum}");
            }
        }
    }
}
