using UnityEngine;

/* [0] ���� : StringClass
		- string == System.String
		- ����(��)�� ���� ���ϱ� = �迭�̸�.Length
*/

public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        string s1 = "Hello.";
        System.String s2 = "�ݰ����ϴ�.";
        // [2] ���
        Debug.Log($"{s1}�� ���� : {s1.Length} , {s2}�� ���� : {s2.Length}");
    }
}
