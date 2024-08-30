using System;


namespace _010_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = 100;
            double? dnum = 3312312453123.323d;

            Console.WriteLine($"num: {num}");
            Console.WriteLine($"num: {num.Value}");
            Console.WriteLine($"num: {num.HasValue}");
            Console.WriteLine($"Type: {num.GetType()}");

            Console.WriteLine($"dnum: {dnum}");
            Console.WriteLine($"dnum: {dnum.Value}");
            Console.WriteLine($"dnum: {dnum.HasValue}");
            Console.WriteLine($"Type: {dnum.GetType()}");

            num = null;
            Console.WriteLine($"num: {num.GetValueOrDefault()}");
            Console.WriteLine($"num: {num.HasValue}");
            

            {
                int? nullNum = 100;
                int numCast = (int)nullNum; // 형변환을 해줘야 넣어줄수있다.
            }
        }
    }
}
