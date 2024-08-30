using System;


namespace _005_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                decimal dcNum = 32131231231231.043M; // 수치 접미사(M, m)
                Console.WriteLine($"dcNum: {dcNum}");
            }

            {
                Console.WriteLine("\n 타입 & 크기");
                decimal dcNum = 32131231231231.043M;
                Console.WriteLine($"Type: {dcNum.GetType()} sizeof: {sizeof(decimal)} byte");
            }

            {
                Console.WriteLine("\n 저장 가능 범위");

                decimal minDecimal = decimal.MinValue;
                decimal maxDecimal = decimal.MaxValue;

                Console.WriteLine($"minDecimal: {minDecimal}");
                Console.WriteLine($"maxDecimal: {maxDecimal}");
            }
        }
    }
}
