using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] double�� �Ǽ��� ���� d�� �����ϰ� 12.34�� �ʱ�ȭ.
        double d = 12.34;
        // [2] int�� ������ ���� i�� �����ϰ� 1234�� �ʱ�ȭ.
        int i = 1234;
        // [3] double > int : ������(�Ϲ���, �Ͻ���) ���� ��ȯ.
        d = i;
        Debug.Log("�Ϲ��� ���ĺ�ȯ : " + d);

        d = 12.34;
        i = 1234;
        // [4] double < int : ������� ���� ��ȯ�� �ʿ�.
        i = (int)d; // ( ) : ĳ��Ʈ ������
        Debug.Log("������� ���� ��ȯ : " + i);

        d = 12.34;
        i = 1234;
        // [5] �ٸ� ���İ��� ��ȯ.
        string s = ""; // string ���� s�� �����ϰ� ""(��)���� �ʱ�ȭ �� �ƹ� ���� �ȳ���.
        s = d.ToString();
        s = i.ToString();
        Debug.Log("�ٸ� ���� ��ȯ : " + s);
    }
}
