using UnityEngine;


/* [0] ���� : MethodOverloadDemo
		- �λ��ϴ� �Լ�(Hi)�� ���� �Ͻÿ�.
*/

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ����
        Hi();
        Hi("�ݰ����ϴ�.");
        Hi("�����մϴ�.", 3);
    }
    // [1-1] ���� : �Ű������� ���� �Լ�.
    void Hi()
    {
        Debug.Log("�ȳ��ϼ���.");
    }
    // [1-2] ���� : �Ű�����(string message)�� �ִ� �Լ�.
    void Hi(string message)
    {
        Debug.Log(message);
    }
    // [1-3] ���� : �Ű������� �Է� (message)�� �Ű������� ���� (count) Ƚ����ŭ �ִ� �Լ�.
    void Hi(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }
}
