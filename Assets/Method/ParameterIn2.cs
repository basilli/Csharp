using UnityEngine;


/* [0] 개요 : ParameterIn2
		- 값 전달방법(int num) : 구조체
*/

namespace Method
{
    // [1-1] 정의
    struct Point
    {
        public int x;
        public int y;
    }
    public class ParameterIn2 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [2-1] 결과
            Point point = new Point();
            point.x = 10;
            Debug.Log($"[1]Point.x : {point.x}");       // ) [1] = 10

            PrintPoint(point);

            // [2-2] 결과
            Debug.Log($"[3]Point.x : {point.x}");       // ) [3] = 10

        }
        // [1-2] 정의 : 매개변수로 Struct를 입력받아 Struct에 포함되어 있는 변수를 풀력하는 함수.
        void PrintPoint(Point point)
        {
            point.x = 20;
            Debug.Log($"[2]Point.x : {point.x}");       // ) [2] = 20
        }
    }
}
