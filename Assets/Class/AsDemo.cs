using UnityEngine;


/* [0] 개요 : AsDemo
		- As 연산자 : ~ 형식으로 변환하기
            - ~ 형식으로 변환이 가능하면 변환거나, 변환이 불가능 하면 null을 반환함.
*/
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : 형식 변환이 가능.
        object s = "반갑습니다.";
        string r1 = s as string;
        // [1-2] 결과
        Debug.Log($"[1] {r1}");

        // [2-1] 정의 : 형식 변환이 불가능.
        object i = 1234;
        string r2 = i as string;
        // [2-2] 결과
        if (r2 == null)
        {
            Debug.Log("[2] null입니다.");
        }

        // [3-1] 정의
        object i2 = 5678;
        // [3-2] 결과
        if (i2 is string)
        {
            string r3 = i2 as string;
        }
        else
        {
            Debug.Log("[3] 변환 불가능.");
        }
    }
}
