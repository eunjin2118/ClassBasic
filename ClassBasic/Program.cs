using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThirdClass abc; // 여기에서 먼저 만들고 단축키로 클래스 생성 가능
            ABCClass abc2; // 동급의 클래스
            // 중첩 클래스
            InnerClass inn; // 이 클래스 안에서 잠깐 사용하는 클래스

            // 이름 충돌이 날 경우 가장 가까운것을 가져 옴
            Math math = new Math();
            //Console.WriteLine(Math.Abs(-10));
        }
    }

    class Math
    {
        static public int Abs()
        {
            return 0;
        }
    }
    class InnerClass
    {
    }

}

internal class ABCClass
{
}
