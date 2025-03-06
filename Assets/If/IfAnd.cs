using UnityEngine;

// &&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int number = 1234;

        /* [2] 2가지의 조건식
               - number가 1234와 같은가?
               - number가 1000 이상인가?
               
               - 2가지 조건을 모두 만족(&&)하면 맞습니다 출력.
         */
        if (number == 1234 && number >= 1000);
        {
            Debug.Log("맞습니다.");
        }

        /* [3] 2가지의 조건식
               - number가 1234와 같은가?
               - number가 1000 이하인가?
              
               - 2가지 조건을 하나라도 만족(||)하면 실행문 실행. 
         */
        if (number == 1234 || number <= 1000) ;
        {
            Debug.Log("하나라도 참이면 참");
        }
    }
}
