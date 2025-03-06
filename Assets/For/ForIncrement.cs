using UnityEngine;


/* [0] 개요 : ForIncrement(증감식)
        - 0부터 10까지 카운팅을 하되, 2씩 증가하면서 출력하도록 할 것.
        - 0,2,4 ... 8,10
 */
public class ForIncrement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        for (int i = 0; i < 11; i = i+2)
        {
            Debug.Log(i);
        }
    }
}
