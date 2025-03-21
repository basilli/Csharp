using UnityEngine;

/* [0] 개요 : AbstractClassNote
*/

namespace Inheritance10
{

    public class AbstractClassNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 결과 : SquareClass의 인스턴스 생성.
            Square square = new Square(10);
            Debug.Log(square.GetArea());

            // [1-2] 결과 : CircleClass의 인스턴스 생성.
            Circle circle = new Circle(10);
            Debug.Log(circle.GetArea());
        }
    }
}
