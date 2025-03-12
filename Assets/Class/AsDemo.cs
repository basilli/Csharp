using UnityEngine;


/* [0] ���� : AsDemo
		- As ������ : ~ �������� ��ȯ�ϱ�
            - ~ �������� ��ȯ�� �����ϸ� ��ȯ�ų�, ��ȯ�� �Ұ��� �ϸ� null�� ��ȯ��.
*/
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] ���� : ���� ��ȯ�� ����.
        object s = "�ݰ����ϴ�.";
        string r1 = s as string;
        // [1-2] ���
        Debug.Log($"[1] {r1}");

        // [2-1] ���� : ���� ��ȯ�� �Ұ���.
        object i = 1234;
        string r2 = i as string;
        // [2-2] ���
        if (r2 == null)
        {
            Debug.Log("[2] null�Դϴ�.");
        }

        // [3-1] ����
        object i2 = 5678;
        // [3-2] ���
        if (i2 is string)
        {
            string r3 = i2 as string;
        }
        else
        {
            Debug.Log("[3] ��ȯ �Ұ���.");
        }
    }
}
