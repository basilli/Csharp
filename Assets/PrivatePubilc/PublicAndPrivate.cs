using PrivatePublic;
using UnityEngine;

public class PublicAndPrivate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : Car 클래스의 인스턴스 생성.
        Car myCar = new Car();
        // [1-2] 가정 : Car 클래스의 객체를 통해 Public한  필드에 접근해서 사용.
        myCar.name = "홍길동.";
        // [1-3] 결과
        Debug.Log(myCar.name);

        // [2-1] 가정 : 클래스의 객체를 통해 Private한 필드에 접근해서 사용. → (X)
        // ) myCar.age = 21; → NG.
        // ) myCar.address = "수원"; → NG.
        // [2-2] 가정 : 클래스의 객체를 통해 Public한 필드에 접근해서 사용. → (O)
        myCar.Hi();
        // [2-3] 가정 : 클래스의 객체를 통해 Private한 필드에 접근해서 사용. → (O)
        // ) myCar.Bye(); → NG.
    }
}
