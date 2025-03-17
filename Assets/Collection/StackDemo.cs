using System.Collections;
using UnityEngine;


/* [0] ���� : StackDemo
		- Stack�� ����Ϸ��� ��ο� ���� 'using System.Collections;�� �߰��ؾ���.
		- Stack Ŭ���� : LIFO(Last In First Out) ���·� �����͸� �����ϴ� ���� Ŭ����.
            - LIFO : ���Լ���, ���� �������� ���� �����͸� ���� ���� ������.
            - �ֹ��� ���ø� �׾Ƴ����� ���� ����� ������ ����.
		- Push ( ) : ���� ������ �����͸� �Է�.
		- Pop ( ) : ���� ������ �����͸� ���.
        - Peek ( ) : ���� �������� �������� ���� ���(�������� �Է�)�� ��ġ�� �������� ���� ��ȯ.
        - Count : ���� ������ ���� ����Ǿ��ִ� �������� ��. �� Array�� .Length�� ���������� Stack ���� Count�� ������ ������.
        - Clear ( ) : ���� �������� ������ ��� ����.
		- Overflow : ���� ������ �����Ͱ� ���� á�� �� �߻�.
        - Underflow : ���� ������ �����Ͱ� �� ����� �� �߻�.
*/

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : Stack Ŭ������ ��ü(�ν��Ͻ�, ��ü) ����.
        Stack stack = new Stack();

        // [2] ���� : ������ �Է�.
        stack.Push("ù��°");
        stack.Push("�ι�°");
        stack.Push("����°");

        // [3-1] ��� : ������ ���.
        Debug.Log(stack.Pop());     // ) ����°
        Debug.Log(stack.Pop());     // ) �ι�°
        Debug.Log(stack.Pop());     // ) ù��°
        // [3-2] ��� : ����ִ� Stack���� Pop�� �̿��Ͽ� �����͸� ���. �� Underflow
        try
        {
            Debug.Log(stack.Pop());
        }
        catch (System.Exception ex)
        {
            Debug.Log($"�������� : {ex.Message}");
        }
    }
}
