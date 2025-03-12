using UnityEngine;


/* [0] 개요 : SquareClass
*/

public class SquareClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] 정의 : 클래스의 static(정적인) 메서드 GetName( ) 호출.
                - 형태
                    정적 메서드의 호출 방법 : 클래스이름(Square).메서드이름 (GetName)
        */
        string name = Square.GetName();
        Debug.Log(name);
    }
}
