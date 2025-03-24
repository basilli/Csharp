using UnityEngine;

/* [0] 개요 : CarWorld
		- 객체지향 프로그래밍
			- 추상화(Abstruct)
			- 캡슐화()
			- 상속(Inheritance)
			- 다형성
*/

namespace InterfaceTest
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : Car 인스턴스 생성.
            Car campingCar = new Car("캠핑카");
            campingCar.Run();
            // [1-2] 정의 : 속성
            Car sportCar = new Car();
            sportCar.Name = "스포츠카";
            sportCar.Run();
            // [1-3] 정의 : 
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            foreach (var c in cars)
            {
                Debug.Log(c);
            }
        }
    }
}