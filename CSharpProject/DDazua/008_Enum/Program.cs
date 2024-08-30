using System;

namespace _008_Enum
{
    enum COLOR_TYPE
    {
        WHITE,
        RED,
        BLUE,
        BLACK,
        SIZE,
    }

    enum DAY : ushort
    {
        MON, THE, WED, TUE, FRI, SAT, SUN, SIZE
    }

    enum NUMBER
    {
        ONE = 1,
        TWO, // 2
        THREE, // 3
        FIVE = 5,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"COLOR_TYPE.WHITE: {COLOR_TYPE.WHITE}");
            Console.WriteLine($"COLOR_TYPE.BLUE: {COLOR_TYPE.BLUE}");

            // 형변환
            Console.WriteLine($"COLOR_TYPE.WHITE: {(int)COLOR_TYPE.WHITE}");
            Console.WriteLine($"COLOR_TYPE.BLUE: {(int)COLOR_TYPE.BLUE}"); 
            Console.WriteLine($"COLOR_TYPE.SIZE: {(int)COLOR_TYPE.SIZE}");

            

            // 변환
            {
                DAY day = DAY.MON;

                Console.WriteLine($"day: {day}");
                Console.WriteLine($"DAY.MON: {(short)DAY.MON}");

                int total = (short)DAY.MON + (short)DAY.SIZE;
                Console.WriteLine($"total: {total}");
            }

            {
                Console.WriteLine($"NUMBER.ONE: {(int)NUMBER.ONE}");
                Console.WriteLine($"NUMBER.TWO: {(int)NUMBER.TWO}");
                Console.WriteLine($"NUMBER.THREE: {(int)NUMBER.THREE}");
                Console.WriteLine($"NUMBER.FIVE: {(int)NUMBER.FIVE}");
            }
        }
    }
}
