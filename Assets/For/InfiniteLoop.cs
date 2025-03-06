using UnityEngine;


/* [0] 개요 : InfiniteLoop(무한루프)
        - 끝이 나지 않는 반복실행.(=버그)
        - 실행 할 경우, 강제종료를 해야함.
        - 반복문을 만들 경우, 빠져나올 수 있는 로직을 만들어야함.
 */
public class InfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (; ; )
        {
            Debug.Log("무한루프");
        }
    }
}
