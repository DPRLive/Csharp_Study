namespace Csharp_Study
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class S3_Player : S3_Creature
    {
        protected PlayerType type = PlayerType.None;

        protected S3_Player(PlayerType type) : base(CreatureType.Player)
        // Player() 인 디폴트버전 사용불가능
        //protected  사용으로 자식으로만 생성가능하게 만들음
        {
            this.type = type;
        }

        public PlayerType getPlayerType() { return type;}

    }

    class Knight : S3_Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            setInfo(100,10);
        }
    }
    
     class Archer : S3_Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            setInfo(75,12);
        }
    }

     class Mage : S3_Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            setInfo(50,15);
        }
    }
}