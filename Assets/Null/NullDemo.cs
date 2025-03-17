using System;
using UnityEngine;


/* [0] 개요 : NullDemo
        - 변수를 선언할 때 뒤에 ?를 붙이기.
            - Nullable<int> -> int?
            - Nullable<float> -> float?
            - Nullable<int> ni = null;
*/

public class NullDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        // ) bool bln = null;        // ) NG.
        Nullable<bool> bln = null;      // ) OK.

        // [1-1] 결과
        Debug.Log(bln.HasValue);        // ) 값이 없으면 false.
        bln = false;
        Debug.Log(bln.HasValue);        // ) false이라는 값을 갖고있기때문에, true가 나옴.

        // [1-2] 결과
        int? ni = null;
        ni = 10;
        Debug.Log(ni);
    }
}
