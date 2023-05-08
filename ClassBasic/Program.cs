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
        }
    }
    class InnerClass
    {
    }

}

internal class ABCClass
{
}
