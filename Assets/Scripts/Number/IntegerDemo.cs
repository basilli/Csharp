using UnityEngine;

// Integer : ������ ����
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] int�� ������ ���� �� �ִ� ���� ���� ��
        int min = -2147483648;
        // [2] int�� ������ ���� �� �ִ� ���� ū ��
        int max = 2147483647;

        Debug.Log("int ������ �ּڰ�" + min);
        Debug.Log("int ������ �ִ�" + max);
          
    }

}
