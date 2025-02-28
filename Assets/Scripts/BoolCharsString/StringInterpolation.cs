using UnityEngine;

// String Interpolation (���ڿ� ������)
public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "���ڿ� ������";

        Debug.Log("Message : " + message); // [1] ���ڿ� + ����
        Debug.Log($"Message : {message}"); // [2] ���ڿ� ������
        Debug.Log("Message : {message}"); // [3] $�� ����, message�� ���� �ȳ���
        Debug.Log($"Message : message"); // [4] {}�� ������� message�� ���� �ȳ���

        // String. Format
        string msg = string.Format("{0}��, {1}", "ȫ�浿", "�ȳ��ϼ���"); // [5] Format�� ���� : {0}�ڸ��� "ȫ�浿" �� {1)�ڸ��� "�ȳ��ϼ���"

        Debug.Log(msg);
    }

}
