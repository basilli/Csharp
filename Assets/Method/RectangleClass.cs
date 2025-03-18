using UnityEngine;


/* [0] 개요 : RectangleClass
		- 형태.
            - Public(or Private) void(반환타입이 없음, int, string) 메서드 이름(매개변수)
                {
                    //메서드의 실행문.
                }
		- 이름(style).
		    - 동사 + 이름
            - ( )을 가져온다 → GetName( ), GetHP( )
            - ( )을 저장한다 → SetName("홍길동");
*/

namespace Method
{

    public class RectangleClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 결과 : Rectangle Class의 인스턴스 생성.
            Rectangle rect = new Rectangle();
            Debug.Log(rect.GetName());
        }
    }
}
