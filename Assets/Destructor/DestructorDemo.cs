using UnityEngine;


/* [0] 개요 : DestructorDemo
*/

namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의
            // [2] 가정

            // [1-1] 결과 : Car Class의 인스턴스를 생성하고 달리기 구현.
            Car whiteCar = new Car();
            whiteCar.Run();
            // [1-2] 결과 : WhiteCar 폐차 → GC에서 알아서 소멸.
            Car blueCar = new Car("파란");
            blueCar.Run();
            Car redCar = new Car("빨간");
            redCar.Run();
        }
    }
}
