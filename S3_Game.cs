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
        private S3_Monster monster = null;
        protected Random rand = new Random();

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
                    processField();
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

        private void processField()
        {
            Console.WriteLine("필드에 입장했습니다!");
            Console.WriteLine("[1] 몬스터와 전투하기");
            Console.WriteLine("[2] 일정 확률로 마을 돌아가기");

            createRandomMonster();

            string input = Console.ReadLine();
            switch (input)
            {
                case "1" :
                    processFight();
                    break;
                case "2" :
                    tryEscape();
                    break;
            }
        }

        private void createRandomMonster()
        {
            int randValue = rand.Next(0,3);
            switch (randValue)
            {
                case 0 :
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다.");
                    break;
                case 1 :
                    monster = new Orc();
                    Console.WriteLine("오크가 생성되었습니다.");
                    break;
                case 2 :
                    monster = new Skeleton();
                    Console.WriteLine("스켈레톤이 생성되었습니다.");
                    break;
            }
        }

        private void processFight()
        {
            while(true)
            {
                int damage = player.getAttack();
                monster.onDamaged(damage);
                if (monster.isDead())
                {
                    Console.WriteLine("승리!");
                    Console.WriteLine($"남은 체력 : {player.getHp()}");
                    break;
                }

                damage = monster.getAttack();
                player.onDamaged(damage);
                if (player.isDead())
                {
                    Console.WriteLine("패배!");
                    Console.WriteLine($"남은 체력 : {player.getHp()}");
                    mode = GameMode.Lobby;
                    break;  
                } 
            }     
        }

        private void tryEscape()
        {
            int randValue = rand.Next(0,101);
            if(randValue < 33)
                mode = GameMode.Town;
            else
                processFight();            
        }

    }
}