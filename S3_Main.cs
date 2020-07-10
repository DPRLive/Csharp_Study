// textRPG2 버전. 클래스 사용
using System;

namespace Csharp_Study
{
    class S3_Main
    {     
        static void Main(string[] args)
        {
            S3_Game game = new S3_Game();

            while(true)
            {
                game.process();
            }
        }
    }
}