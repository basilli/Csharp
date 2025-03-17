using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.TestTools;


/* [0] 개요 : AveragePractice
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- using System.Linq;을 상부에 추가할 것.
		- [Q]
            - 입력데이터 {90, 65, 78, 50, 95}
            - 국어점수 중에서 70점 이상이고, 95점 이하인 점수들의 평균을 구하라.
        - [output] - 소숫점 2자리.
            - 평균점수 : average
*/

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 70점 이상, 95점 이하 점수의 평균.
        int[] data = { 90, 65, 78, 50, 95 };
        double average = 0;     // ) 점수의 평균.
        int sum = 0;        // ) 점수의 합.
        int count = 0;       // ) 범위내의 점수.

        // [2-1] 가정 : 범위.
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 70 && data[i] <= 95)
            {
                sum = sum + data[i];
                    count++;
            }
        }
        // [2-2] 가정 : 평균값.
        if (count > 0)
        {
            average = sum / (double)count;
        }
        // [3] 결과
        Debug.Log($"평균점수 : {average:0.00}");
    }
}
