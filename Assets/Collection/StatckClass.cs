// [1] ����
using System.Collections;
using UnityEngine;


/* [0] ���� : StatckClass
		- Collections : Stack, Queue, ArrayList, HashTable�� ����.
        - Stack�� ����Ϸ��� ��ο� ���� 'using System.Collections;�� �߰��ؾ���.
*/

public class StatckClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : Stack Ŭ������ �ν��Ͻ�(��ü) ����.
        Stack st = new Stack();

        // [2] ���� : ���ÿ� �����͸� �ֱ�(Push)
        st.Push("First");
        st.Push("Second");

        // [3] ��� : ���ÿ� �����͸� ������(Pop)
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
    }
}
