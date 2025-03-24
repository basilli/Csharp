using UnityEngine;

/* [0] 개요 : Character
*/

namespace Override
{
    // [1-1] 정의 : 플레이어, 몬스터 등 모든 Character의 ParentClass(Character의 공통기능)
    public abstract class Character
    {
        // [1-2] 정의 : 
        public abstract int GetTotalAttack();
        public int health;
        public int baseATK;
        // [1-3] 정의 : Constructor → Member 초기화.
        public Character(int hp, int atk)
        {
            this.health = hp;
            this.baseATK = atk;
        }
        // [1-4] 정의 : 매개변수로 나에게 데미지를 주는 Character 객체를 전달.
        public void TakeDamage(Character other)
        {
            health -= other.GetTotalAttack();
        }
    }
    // [1-5] 정의 : 플레이어
    public class Player : Character
    {
        // [1-6] 정의 : Player's Constructor
        public Player() : this(10, 20) { }
        public Player(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseATK;                        // ) 장비, 스킬, 상성등을 누적시킴.
            return total;
        }
    }



    // [2-1] 정의 : 몬스터
    public class Monster : Character
    {
        // [2-2] 정의 : Monster's Constructor
        public Monster(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseATK;                        // ) 장비, 스킬, 상성등을 누적시킴.
            return total;
        }
    }



    // [3-1] 정의 : 고블린
    public class Goblin : Monster
    {
        // [3-3] 정의 : 
        public int posX, posY;

        // [3-2] 정의 : Constructor
        public Goblin(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseATK;                        // ) 장비, 스킬, 상성등을 누적시킴.
            return total;
        }
        // [3-3] 정의 : 
        public void SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }
    }



    // [4-1] 정의 : 고블린
    public class Skeleton : Monster
    {
        // [4-2] 정의 : Constructor
        public Skeleton(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseATK;                        // ) 장비, 스킬, 상성등을 누적시킴.
            return total;
        }
    }



    // [5-1] 정의 : 좀비
    public class Zombie : Monster
    {
        // [4-2] 정의 : Constructor
        public Zombie(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseATK;                        // ) 장비, 스킬, 상성등을 누적시킴.
            return total;
        }
    }
}
