using UnityEngine;
using System.Collections;


/* [0] 개요 : QueueDemo
 * 		- Queue를 사용하려면 상부에 적힌 'using System.Collections;을 추가해야함.
		- Queue 클래스 : FIFO(First In First Out) 형태로 데이터를 저장하는 관리 클래스.
	    	- FIFO : 선입선출, 가장 먼저 넣은 데이터를 가장 먼저 꺼낸다.
            - 입구와 출구가 정해진 에스컬레이터와 비슷한 데이터 구조.
		- Enqueue ( ) : 큐 구조에 데이터를 입력.
        - Dequeue ( ) : 큐 구조에 데이터를 출력.
*/

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Queue 클래스의 객체(인스턴스) 생성.
        Queue queue = new Queue();

        // [2] 가정 : 데이터 입력.
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // [3] 결과 : 데이터 출력.
        Debug.Log(queue.Dequeue());     // ) 10
        Debug.Log(queue.Dequeue());     // ) 20
        Debug.Log(queue.Dequeue());     // ) 30
    }
}
