using UnityEngine;

// ���ڿ� ��.
public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : ����, s1�� s2�� ������ Same�̶�� ���.
        string s1 = "Hello";
        string s2 = "Hello";
        // [1-1]
        if (s1 == s2)
        {
            Debug.Log("Same");
        }

        // [2] ���� : ����, bln ���� false�̸� ���๮�� ����.
        bool bln = false;
        // [2-1]
        if (bln == false)
        {
            Debug.Log("bln : " + bln);
        }

        // [3] ���� : !bln���� ���̸� ���๮�� ����.
        // [3-1]
        if (!bln)
        {
            Debug.Log("!bln : " + !bln);
        }
    }

}
