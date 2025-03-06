using UnityEngine;


/* [0] 개요 : ForCountDownDemo
        - 1,2,3,4,5(오름차순) or 5,4,3,2,1(내림차순)
        - 5,4,3,2,1(내림차순)
 */
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        for (int n = 0; n < 5; n++)
        {
            Debug.Log($"감소 Countdown : {5-n}");
        }
    }
}


/* [A]
         // [1-1] 정의 : 오름차순
        for (int i = 1; i < 5 + 1; i++)
        {
            Debug.Log($"증가 Countdown : {i}");
        }

        Debug.Log("----------------------------------------------------------");

        // [1-2] 정의 : 내림차순
        for (int i = 5; i > 1 - 1; i--)
        {
            Debug.Log($"감소 Countdown : {i}");
        }
 */
