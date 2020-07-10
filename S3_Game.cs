using System;

namespace Csharp_Study
{
    public enum GameMode
    {
        Lobby,
        Town,
        Field
    }

    class S3_Game
    {
        private GameMode mode = GameMode.Lobby;
        private S3_Player player = null;

        public void process()
        {
            switch (mode)
            {
                case GameMode.Lobby :
                    processLobby();
                    break;
                case GameMode.Town :
                    processTown();
                    break;
                case GameMode.Field :
                    //processField();
                    break;
            }
        }

        private void processLobby()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 마법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1" :
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2" :
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3" :
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }

        private void processTown()
        {
            Console.WriteLine("마을에 입장했습니다!");
            Console.WriteLine("[1] 필드로 가기");
            Console.WriteLine("[2] 로비로 돌아가기");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1" :
                    mode = GameMode.Field;
                    break;
                case "2" :
                    mode = GameMode.Lobby;
                    break;
            }
        }
    }
}