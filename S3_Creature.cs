using System;

namespace Csharp_Study
{
    public enum CreatureType
    {
        None,
        Player = 1,
        Monster = 2
    }

    class S3_Creature
    {
        protected CreatureType type;
        protected int hp = 0;
        protected int attack = 0;

        protected S3_Creature(CreatureType type)
        {
            this.type = type;
        }    

        public void setInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        public int getHp() { return hp; }
        public int getAttack() { return attack; }

        public bool isDead() { return hp <= 0;}
        public void onDamaged(int damage)
        {
            hp -= damage;
            if(hp < 0)
                hp = 0;
        }
    }

}