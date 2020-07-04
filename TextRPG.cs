using System;

namespace Csharp_Study
{
    class TextRPG
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }

        static ClassType SelClass() 
        {
            ClassType select = ClassType.None;
            Console.WriteLine("직업을 선택하세요!\n[1] 기사\n[2] 궁수\n[3] 마법사");
            String input = Console.ReadLine();

            switch (input)
            {
                case "1": {
                    select = ClassType.Knight;
                    break;
                }
                case "2": {
                    select = ClassType.Archer;
                    break;
                }
                case "3": {
                    select = ClassType.Mage;
                    break;
                }
            }
            return select;
        }

        static void CreatePlayer(ClassType select, out Player player)
        {
            switch (select)
            {
                case ClassType.Knight: {
                    player.hp = 100;
                    player.attack = 10;
                    break;
                }
                case ClassType.Archer: {
                    player.hp = 75;
                    player.attack = 12;
                    break;
                }
                case ClassType.Mage: {
                    player.hp = 50;
                    player.attack = 15;
                    break;
                }
                default:{
                    player.hp = 0;
                    player.attack = 0;
                    break;
                }
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);

            switch (randMonster)
            {
                case (int)MonsterType.Slime: {
                    Console.WriteLine("슬라임이 스폰되었습니다.");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                }
                case (int)MonsterType.Orc: {
                    Console.WriteLine("오크가 스폰되었습니다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                }
                case (int)MonsterType.Skeleton: {
                    Console.WriteLine("스켈레톤이 스폰되었습니다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                }
                default:{
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
                }
            }
        }

        static void EnterField()
        {
            Console.WriteLine("필드에 접속했습니다!");
            Monster monster;
            CreateRandomMonster(out monster);
            Console.WriteLine("[1] 전투 모드로 돌입\n[2] 일정 확률로 마을로 도망");
        }

        static void EnterGame()
        {
            while(true){
                Console.WriteLine("마을에 접속했습니다!\n[1] 필드로 간다.\n[2] 로비로 돌아가기.");
                string input = Console.ReadLine();
                if (input == "1")
                    EnterField();          
                else if (input == "2")
                    break;
                }
        }

        static void Main(string[] args)
        {
            while(true)
            {
                ClassType select = SelClass();
                if(select != ClassType.None)
                {
                    Player player;
                    CreatePlayer(select, out player);
                    EnterGame();
                }
            }
        }
    }
}