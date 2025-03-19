using UnityEngine;


/* [0] 개요 : ExpressionFuctionㄴ
*/

namespace Method
{

    public class ExpressionFuction : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [2] 결과
            work();        // ) Work
            Hello();        // ) Hola
            Debug.Log(DoubleValue(4));      // ) 8
            Debug.Log(Sum(3, 5));       // ) 8
        }
        // [1-1] 정의 : 기본형.
        void work()
        {
            Debug.Log("Work");
        }
        // [1-2] 정의 : 축약형.
        void Hello() => Debug.Log("Hola");
        // [1-3] 정의 : 매개변수로 입력받은 값을 두배로 반환하는 함수.
        int DoubleValue(int value) => value * 2;
        // [1-4] 정의 : 매개변수로 입력받은 두 정수의 합을 반환하는 함수.
        int Sum(int a, int b) => a + b;
    }
}
