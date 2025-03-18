using UnityEngine;


/* [0] 개요 : ConstructorForwarding
*/

namespace Constructor
{


    public class ConstructorForwarding : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 결과 : Money Class의 인스턴스 생성.
            Money basic = new Money();

            // [1-2] 결과 : Money Class의 인스턴스 생성 → 매개변수가 있는 생성자 호출.
            Money bonus = new Money(2000);
        }
    }
}
