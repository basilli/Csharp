using System.Runtime.CompilerServices;
using UnityEngine;


/* [0] 개요 : ArrayDescription
        - Array(배열) : 하나의 이름으로 같은 데이터 형식을 여개를 보관해 놓는 그릇.
        - Variable(변수) : 프로그램에서 사용하는 데이터를 저장해 놓는 그릇.
        - // 데이터타입[ ] 변수명(이름);
 */
public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 10;
            // [1-1] 배열선언
            int[] numbers;
            // [1-2] 배열의 요소수 생성(그릇의 갯수 및 크기 설정)
            numbers = new int[n];   // ) 0~n-1
            // [1-3] 배열의 저장 및 대입(초기화)
            numbers[0] = 3840;
            numbers[1] = 2160;
        // [1-4] 배열의 사용
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);
    }
}
