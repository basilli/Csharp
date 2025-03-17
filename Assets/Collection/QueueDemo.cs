using UnityEngine;
using System.Collections;


/* [0] ���� : QueueDemo
 * 		- Queue�� ����Ϸ��� ��ο� ���� 'using System.Collections;�� �߰��ؾ���.
		- Queue Ŭ���� : FIFO(First In First Out) ���·� �����͸� �����ϴ� ���� Ŭ����.
	    	- FIFO : ���Լ���, ���� ���� ���� �����͸� ���� ���� ������.
            - �Ա��� �ⱸ�� ������ �����÷����Ϳ� ����� ������ ����.
		- Enqueue ( ) : ť ������ �����͸� �Է�.
        - Dequeue ( ) : ť ������ �����͸� ���.
*/

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : Queue Ŭ������ ��ü(�ν��Ͻ�) ����.
        Queue queue = new Queue();

        // [2] ���� : ������ �Է�.
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // [3] ��� : ������ ���.
        Debug.Log(queue.Dequeue());     // ) 10
        Debug.Log(queue.Dequeue());     // ) 20
        Debug.Log(queue.Dequeue());     // ) 30
    }
}
