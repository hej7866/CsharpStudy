using System;


namespace _009_Var
{
    internal class Program
    {
        // var numVar = 100;              에러 : 불가(멤버 변수 사용불가)

        // static var Func() {}           에러 : 함수의 반환형으로 사용 불가
        // static var Func(var a, var b)  에러 : 함수의 파라미터로 사용 불가
        static void Main(string[] args)
        {
            var numVar = 100;
            var numFVar = 0.0043f;

            Console.WriteLine($"numVar: {numVar}");
            Console.WriteLine($"numFVar: {numFVar}");

            // var numNull = null;  null초기값은 사용 불가
        }
    }
}
