using System;

namespace Csharp_Study
{
    class S1_RSPGame
    {
        static void Main(string[] args)
        {
            // 가위 0 바위 1 보 2
            Random rand = new Random();
            int Ai = rand.Next(0,3); // 0~2사이의 랜덤 정수
            Console.WriteLine("가위 0, 바위 1, 보 2. 선택하세요");
            int choice = Convert.ToInt32(Console.ReadLine()); // 입력받음.

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위 입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위 입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보 입니다.");
                    break;
            }

            switch (Ai)
            {
                case 0:
                    Console.WriteLine("Ai의 선택은 가위 입니다.");
                    break;
                case 1:
                    Console.WriteLine("Ai의 선택은 바위 입니다.");
                    break;
                case 2:
                    Console.WriteLine("Ai의 선택은 보 입니다.");
                    break;
            }

            if (choice == Ai)
                Console.WriteLine("무승부 입니다.");
            else if ( (choice == 0 && Ai == 1) || (choice == 1 && Ai == 2) || (choice == 2 && Ai == 0) )
                Console.WriteLine("당신의 패배 입니다.");
            else 
                Console.WriteLine("당신의 승리 입니다.");
        }
    }
}
/* 개선할 부분으로는 가위,바위,보는 변수명을 이용하는것이 수정시 용이함.
    근데 그러면 switch case 문에서 문제가 있을수 있으므로 const int ROCK = 1; 같은 방법을 이용해
    상수로 설정함. 하지만 클래스 이용하는게(열거형) 더 좋긴함. */