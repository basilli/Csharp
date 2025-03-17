using UnityEngine;
using Korea.Suwon;      // ) Korea.에 묶여있는 Suwon이라는 클래스를 가져다 사용 이라고 선언.
using Su = Korea.Suwon;     // ) 별칭


/* [0] 개요 : NameSpaceNote
		- NameSpace 이름 전체를 지정해서 사용하기.
*/

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의
        Korea.Seoul.Car se = new Korea.Seoul.Car();     // ) korea의 seoul의 car을 se라는 객체 만들기.
        se.Run();       // ) = 서울 자동차가 달립니다.
        // [1-2] 정의
        Korea.Suwon.Car su = new Korea.Suwon.Car();     // ) korea의 suwon의 car을 se라는 객체 만들기.
        su.Run();       // ) = 수원 자동차가 달립니다.

        // [2-1] 가정 : NameSpace 선언부에 using을 선언하여 사용하기.
        Car seoul = new Car();
        seoul.Run();        // ) 수원 자동차가 달립니다. → NameSpace를 붙이지 않고 가져올 수 있는 것은 Suwon밖에 없기때문.
        // [2-2] 가정 : 별칭을 지정해서 사용하기.
        Su.Car suwon = new Su.Car();
        suwon.Run();
        // [2-3] 가정 : truck 호출하기.
        Korea.Seoul.Truck truck = new Korea.Seoul.Truck();
        truck.Run();
    }
}
