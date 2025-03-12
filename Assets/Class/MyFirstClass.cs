using UnityEngine;


/* [0] 개요 : MyFirstClass
*/

public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1-1] 정의 : static(정적) 메서드 호출 → StaticMethod( ) 호출.
         */
        ClassMember.StaticMethod();     // ) 클래스이름( ).메서드이름 ( )
        // ClassMember.InstanceMethod();        // ) NG.

        /* [1-2] 정의 : Instance 메서드 호출 → InstanceMethod( ) 호출.
                - new 라는 키워드를 이용하여 새로운 객체를 생성.
         */
        ClassMember member = new ClassMember();     // ) (클래스이름) 객체이름 = new 클래스이름( );
        member.InstanceMethod();        // ) (객체이름).메서드 이름.
        // member.StaticMethod();        // ) NG.
    }
}
