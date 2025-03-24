using UnityEngine;

/* [0] 개요 : InterfaceDescription
		- Interface(인터페이스)
            - 상속받은 ChildClass가 특정 Member를 반드시 구현되어야함을 보증.
		    - 상속받은 ChildClass가 특정 Member를 구현하도록 강제함.
            - Interface의 이름을 지을 때, 맨 앞에 있는 문자는 대문자 I를 붙일 것.
		- 형식
            public interface (인터페이스이름)
            {
                Method이름();     // ) Method 선언, 구현 생략.
            }
*/

namespace Interface
{

    public class InterfaceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : ICar Interface 인스턴스 생성.
            // ) ICar icar = new ICar(); → NG.
            // [1-2] 정의 : ICar Interface를 상속받은 Car 클래스의 인스턴스 생성.
            Car car = new Car();
            car.Go();
        }
    }
}