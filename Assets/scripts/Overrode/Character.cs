using UnityEngine;
namespace Override
{
    public abstract class Character
    {
        public abstract int GetTotalAttack();
        public int health;
        public int baseAtk;

        public Character(int hp, int atk)
        {
            this.health = hp;
            this.baseAtk = atk;
        }
        public void TakeDamage(Character other)
        {
            health -= other.GetTotalAttack();
        }

    }
    public class Player : Character
    {
        public Player() : this(10,20) { }
        public Player(int hp, int atk) : base(hp, atk)
        {
        }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
    }
    public class Monster : Character
    {
        public Monster(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }



    }
    public class Goblin : Monster
    {
        public int posX, posy;
        public Goblin(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
        public void SetPosition(int x, int y)
        {
            this.posX = x;
            this.posy = y;
        }
    }
    public class Skeleton : Monster
    {
        public Skeleton(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
    }
    public class Zombie : Monster
    {
        public Zombie(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            return total;
        }
    }
}