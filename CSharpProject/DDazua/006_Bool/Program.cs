using System;


namespace _006_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEqual = 100 == 100; // == 같다 비교연산자
            bool isResult = 100 < 10;

            Console.WriteLine($"isEqual: {isEqual}");
            Console.WriteLine($"isResult: {isResult}");

            bool isTrue = true; // == 같다 비교연산자
            bool isFalse = false;

            Console.WriteLine($"isTrue: {isTrue}");
            Console.WriteLine($"isFalse: {isFalse}");
        }
    }
}
