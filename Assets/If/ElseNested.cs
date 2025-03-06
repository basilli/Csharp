using UnityEngine;


// [0] 개요 : else 중첩문
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        char input = '1';

        /*
          [2] 가정 및 결과
                intput 'y' 이면, Yes 출력.
                intput 'n' 이면, No 출력.
                intput 그 외 나머지 이면, CANCEL 출력.
         */
        if (input == 'y')
        {
            Debug.Log("Yes");
        }
        else // else는 if와 같이 있어야 함. 혼자서 사용할 수 없음.
        {
            if (input =='n')
            {
                Debug.Log("No");
            }
            else
            {
                Debug.Log("CENCEL");
            }
        }
    }
}
