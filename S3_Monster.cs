using System;

namespace Csharp_Study
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    class S3_Monster : S3_Creature
    {
        protected MonsterType type;

        protected S3_Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType getMonsterType() { return type;}
    }

    class Slime : S3_Monster 
    {
        public Slime() : base(MonsterType.Slime)
        {
            setInfo(10, 1);
        }
    }

    class Orc : S3_Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            setInfo(20, 2);
        }
    }

    class Skeleton : S3_Monster {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            setInfo(15, 5);
        }
    }
}