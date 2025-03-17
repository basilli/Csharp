using UnityEngine;
using System.Collections;


/* [0] ���� : StackNote
*/

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : Stack Ŭ������ �ν��Ͻ�(��ü) ����.
        Stack stack = new Stack();

        // [2] ���� : ������ �Է�.
        stack.Push("���ѹα�");
        stack.Push("����Ư����");
        stack.Push("������");

        // [3-1] ��� : Stack ���� ���(�������� �Է�)�� ��ġ�� �������� ���� ��ȯ.
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        // [3-2] ��� : ������ ���.
        stack.Pop();
        // [3-3] ��� : Stack ���� ���(�������� �Է�)�� ��ġ�� �������� ���� ��ȯ.
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        // [3-4] ��� : ������ ���.
        if (stack.Count > 0)        // ) �����͸� ��� �� ��, �ִ��� ���並 �ϱ� ���� if.
        {
            stack.Pop();
        }
        // [3-5] ��� : Stack ����.
        stack.Clear();
        Debug.Log($"{stack.Count}");
    }
}
