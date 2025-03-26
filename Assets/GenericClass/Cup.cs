using UnityEngine;

/* [0] 개요 : GenericCollection
		- Generic Class : 형식 매개 변수 T에 지정한 형식, 클래스와 맴버의 성질이 결정되는 클래스.
		    - Cup<T> : Cup Of T(전용 컵)
*/

namespace GenericClass
{
    // [1-1] 정의 : Water와 Coffee 선언.
    public class Water { }
    public class Coffee { }

    // [1-2] 정의 : GenericClass 선언. → Class이름<T>
    public class Cup<T>
    {
        public T Content { get; set; }

        // [2-1] 정의 : 매개변수로 입력받은 T형식의 데이터를 출력.
        public void PrintData<T>(T data)
        {
            Debug.Log($"{data}");
        }
    }
}