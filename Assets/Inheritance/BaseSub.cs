using UnityEngine;

/* [0] 개요 : BaseSub
*/

namespace Inheritance
{

    public class BaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : SubClass의 인스턴스 생성.
            SupClass sup = new SupClass();
            sup.Do();       // ) BassClass에 정의된 메서드를 SubClass가 사용할 수 있게 함. (단, Public나 Protected로 선언된 메서드만 가능함)



            // [2] 가정
            // [3] 결과
        }
    }
}
