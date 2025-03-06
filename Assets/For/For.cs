using UnityEngine;


/* [0] 개요 : For
        - 1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램.
        - // Count : 1
        - // Count : 2
        - // Count : 3
        - // Count : 4
        - // Count : 5
 */
public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] 정의
                - 1부터 5까지 증가 하면서 값을 출력. → 5번 반복.
         */
        for (int i = 1; i < 6; i++)
        {
            Debug.Log($"Count : {i}");
        }
    }
}



/* [A] for문에서 가장 많이 쓰임.
     for (int i = 0; i<5; i++)
    {
          Debug.Log($"Count : {i+1} ");
    }
*/

/* [B]
    for (int i = 1; i<=5; i++)
    {
         Debug.Log($"Count : {i}");
    }
*/
