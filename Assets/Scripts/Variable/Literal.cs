using UnityEngine;

// Literal (��)
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� �����
        int num;    // ������ ���� : ���� ǥ��
        double su; // �Ǽ��� ���� : �Ҽ��� ����
        bool flag;  // �ο��� ���� : ��(true) OR ����(false)
        string str;  // ���ڿ� ���� : ���ڿ� ǥ��
        char c;     // ������ ���� : ���� ����ǥ ���, ���ڴ� 1���ڸ� ���

        //[2] ������ ���� ����
        num = 1234;
        su = 3.14159;
        flag = true; // true, false
        str = "�ȳ��ϼ��� �����ؿ� ���־�� �ٽ� ������";
        c = 'a';

        //[3] ���� ����ϱ�
        Debug.Log("num: " + num);
        Debug.Log("su: " + su);
        Debug.Log("flag: " + flag);
        Debug.Log("str: " + str);
        Debug.Log("c: " + c);

    }

}
