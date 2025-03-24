using UnityEngine;

/* [0] 개요 : InterfaceNote
*/

namespace Interface
{

    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : HdCar Class 인스턴스 생성.
            HdCar goodcar = new HdCar(new Good());
            goodcar.Run();
            HdCar badcar = new HdCar(new Bad());
            badcar.Run();
        }
    }
}