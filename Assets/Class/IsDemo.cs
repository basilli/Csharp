using UnityEngine;


/* [0] 개요 : IsDemo
		- 값 형식(Value Type) : 개체에 값 자체를 담고있는 구조.
		- 참조 형식(Reference Type) : 개체가 값을 담고있고, 또 다른 개체가 포인터로 바라보는 구조.
		- Object 데이터 형식 : Object 형식의 변수에는 모든 형식의 데이터 값을 저장(할당) 가능.
        - 박싱(Boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는 것.
        - 언박싱(UnBoxing) : 참조 형식의 데이터를 값 형식의 데이터로 변경하는 것. → 캐스팅

		- is 연산자 : 형식 비교하기.
            - 특정형식인지 아닌지 비교.
            - 특정형식으로 변환이 가능하면 true, 아닐경우 false.
*/

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의
        int i = 1234;
        object o = i;
        Debug.Log(o);
        // [1-2] 정의
        object obj = 9874;
        int num = (int)obj;
        Debug.Log(num);
        // [1-3] 정의
        object s = "안녕하세요.";
        object j = 4567;

        // [2-1] 가정
        if (s is string)
        {
            Debug.Log($"[1] {s}는 null이 아니며, 문자열 형식으로 변환이 가능합니다.");
        }
        // [2-2] 가정
        if (j is int)
        {
            Debug.Log($"[2] {j}는 정수형으로 변환이 가능합니다.");
        }
    }
}
