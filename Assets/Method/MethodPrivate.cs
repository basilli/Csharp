using UnityEngine;


/* [0] 개요 : MethodPrivate
*/

namespace Method
{
    public class MethodPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 결과 : Dog Class의 인스턴스 생성.
            Dog cat = new Dog();
            cat.Eat();                 // ) Public 메서드 호출 가능.
            cat.weight = 30;        // ) Public Field 접근 가능.
            // ) cat.Digest           → NG, Pirvate 메서드 호출 불가능
        }
    }
}
