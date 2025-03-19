using UnityEngine;

/* [0] 개요 : ParameterDemo
*/

namespace Method
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [2-1] 가정 : 몬스터 생성
            Monster monsterA = new Monster(100, 10);
            Monster.monsterCount++;
            Monster monsterB = new Monster(200, 20);
            Monster.monsterCount++;
            // [2-2] 가정 : 전투
            MonsterBattle(monsterB, monsterA);
            MonsterBattle(monsterA, monsterB);
            monsterA.TakeDamage(monsterA, monsterB.atk);
            monsterB.TakeDamage(monsterB, monsterA.atk);


            // [3] 결과
            Debug.Log($"monsterA HP : {monsterA.hp}, ATK : {monsterA.atk}");
            Debug.Log($"monsterB HP : {monsterB.hp}, ATK : {monsterB.atk}");
            Debug.Log($"monsterCount : {Monster.monsterCount}");
        }
        // [1-4] 정의 : 몬스터간의 1:1 전투 구현.
        void MonsterBattle(Monster atkMonster, Monster defMonster)
        {
            defMonster.hp -= atkMonster.atk;
        }
        // [1-1] 정의 : 몬스터를 관리하는 Class.
        public class Monster
        {
            // [1-2] 정의 : Field 선언. → 정적 멤버변수 : 이 프로젝트 내에서 단 하나만 존재하는 값, 공유(Share) → 이 게임에서 생성된 몬스터의 총수량을 저장.
            public static int monsterCount = 0;
            public int hp;      // ) 전역변수
            public int atk;      // ) 전역변수

            // [1-3] 정의 : Constructor(생성자)
            public Monster(int hp, int atk)     // ) 로컬변수
            {
                this.hp = hp; // ) 이름이 똑같을 경우, 전역변수로 처리함.
                this.atk = atk;
            }
            // [1-5] 정의 : 데미지를 입는 함수.
            public void TakeDamage(Monster _this, int damage)
            {
                _this.hp -= damage;     // ) 몬스터A,B의 공격력과 체력이 될 수 있음.
            }
        }
    }
}
