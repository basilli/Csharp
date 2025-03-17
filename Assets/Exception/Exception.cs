using UnityEngine;


/* [0] 개요 : Exception
*/


public class Exception : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* 
        // [1] 정의 : Exception 클래스를 이용하여 예외내용 출력하기.
        [A]
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);      // ) 오류의 내용이 객체에 저장되어, 메세지로 출력됨.
        }
        */

        // [2-1] 정의
        string inputNumber = "3.14";
        int number = 0;

        // [2-2] 가정 및 결과
        try
        {
            number = System.Convert.ToInt32(inputNumber);
            Debug.Log($"입력한 값은 {number} 입니다.");
        }
        catch (System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}는 정수이어야 합니다.");
        }
    }
}
