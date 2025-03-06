using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int i = 100;
        int j = 200;
        int temp;
        Debug.Log($"ó�� i : {i}, j : {j}");

        // [2] �ڸ��ٲٱ�
        temp = i;   // �ӽú���(temp)�� i�� ����.
        i = j;        // i������ j���� ����.
        j = temp;   // j������ �ӽú���(temp)�� ����Ǿ��� i���� ����.
        Debug.Log($"���� i : {i}, j : {j}");

        /*
        [0] �� ���� ȥ�ڼ� Ǭ ��. ��
        int i = 100;
        int j = 200;
        Debug.Log("ó�� i : " + i + ", j : " + j);

        double a = 100;
        double b = 200;
        a = j;
        b = i;
        Debug.Log("���� i : " + a + ", j : " + b);
        */
    }
}



/*
 [Q]
    +, -, *, / ���� ������� ���� i, j�� ���� ���� �ٲپ� �����ϼ���.
    = �� �̿��ϼ���.
    temp ������ ���� �̿��غ�����.

 [Output]
    ó�� i:100, j:200
    ���� i:200, j:100
 */