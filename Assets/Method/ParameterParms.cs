using UnityEngine;


/* [0] 개요 : ParameterParms
		- 가변형 전달 방법 (params int[ ] numbers)
		- params  :가변 길이 매개 변수.
*/

namespace Method
{
    public class ParameterParms : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [2] 결과
            Debug.Log(SumAll(3,5));
            Debug.Log(SumAll(3, 5,7,9));
            Debug.Log(SumAll(3, 5,7,9,11,13));
        }
        // [1] 정의 : 매개변수로 입력받은 정수들의 합을 구하는 메서드.
        int SumAll(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
