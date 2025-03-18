using Constructor;
using UnityEngine;


/* [0] 개요 : ConstructorNote
*/

namespace Constructor
{ 

}

public class ConstructorNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 결과 : Person Class의 인스턴스 생성. → 매개변수가 없는 기본 Constructor
        Person saram1 = new Person();
        Debug.Log(saram1.GetName());
        // [1-2] 결과
        Person saram2 = new Person();
        Debug.Log(saram2.GetName());
        // [1-3] 결과 : 매개변수가 있는 Constructor 호출.
        Person person1 = new Person("백두산");
        Debug.Log(person1.GetName());
        // [1-4] 결과
        Person person2 = new Person("장길산");
        Debug.Log(person2.GetName());
    }
}
