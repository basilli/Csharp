using UnityEngine;

/* [0] 개요 : InheritanceDemo
*/

namespace Override
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : PlayerClass 인스턴스 생성.
            Player player = new Player(100, 30);
            // [1-2] 정의 : MonsterClass 인스턴스 생성.
            Goblin go = new Goblin(50, 10);
            Skeleton sk = new Skeleton(100, 20);
            Zombie zb = new Zombie(200, 30);



            // [2-1] 결과 : Battle
            player.TakeDamage(go);
            DrawHealth(player);
            player.TakeDamage(sk);
            DrawHealth(player);
            player.TakeDamage(zb);
            DrawHealth(player);
            // [2-2] 결과 : Battle
            go.TakeDamage(player);
            DrawHealth(go);
            sk.TakeDamage(player);
            DrawHealth(sk);
            zb.TakeDamage(player);
            DrawHealth(zb);
        }

        /* [A] [2-1]과 [2-2]에 Draw___Health를 맞게 수정하면 OK. → 단 모든 객체를 하나씩 만들어야 함.
        // [1-3] 정의 : Character의 HP.
        public void DrawPlayerHealth(Player player)
        {
            Debug.Log($"{player} : {player.health}");
        }
        // [1-4] 정의 : Goblin의 HP.
        public void drawGoblinHealth(Goblin go)
        {
            Debug.Log($"{go} : {go.health}");
        }
        // [1-5] 정의 : Skeleton의 HP.
        public void drawSkeletonHealth(Skeleton sk)
        {
            Debug.Log($"{sk} : {sk.health}");
        }
        // [1-6] 정의 : Zombie의 HP.
        public void drawZombieHealth(Zombie zb)
        {
            Debug.Log($"{zb} : {zb.health}");
        }
        */

        public void DrawHealth(Character ch)
        {
            Debug.Log($"{ch} : {ch.health}");
        }
    }
}
