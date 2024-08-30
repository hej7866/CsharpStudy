using System;


namespace _004_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                float fNum = 0.001f;
                double dNum = 123234324.9;

                Console.WriteLine($"fNum : {fNum}");
                Console.WriteLine($"dNum : {dNum}");
            }
            

            // 수치 접미사
            {
                Console.WriteLine("\n 수치 접미사");

                float fNum = 0.00014F;  // float(F, f)
                double dNum = 324243234.3d;  // float(D, d)

                Console.WriteLine($"fNum : {fNum}");
                Console.WriteLine($"dNum : {dNum}");
            }

            // 타입 & 크기
            {
                Console.WriteLine("\n 타입 & 크기");

                float fNum = 0.00032f;

                Console.WriteLine($"Type: {fNum.GetType()} sizeof: {sizeof(float)} byte");
                Console.WriteLine($"Type: {432423.434.GetType()} sizeof: {sizeof(double)} byte"); // 아무것도 적지않으면 기본적으로 double로 인식을 한다.
            }

            // 저장 가능 범위
            {
                Console.WriteLine("\n 저장 가능 범위");

                float minFloat = float.MinValue;
                float maxFloat = float.MaxValue;

                Console.WriteLine($"minFloat: {minFloat}");
                Console.WriteLine($"minFloat: {maxFloat}");
            }

            float fNum2 = 1E5f;
            Console.WriteLine($"fNum: {fNum2}");
        }
    }
}
