using UnityEngine;


/* [0] 개요 : Money
*/

namespace Constructor
{


    public class Money
    {
        // [1-1] 정의 : 기본 Constructor.
        public Money() : this(1000)     // ) 기본 Constructor를 Forwarding(전송).
        {
            Debug.Log($"기본 생성자 실행.");
        }
        // [1-2] 정의 : 매개변수가 있는 생성자 → Gold를 입력받아 설정.
        public Money(int gold)
        {
            Debug.Log($"Money : {gold:#,###}");     // ) #,### = 1,234
        }
    }
}
