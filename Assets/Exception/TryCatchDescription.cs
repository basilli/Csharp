using UnityEngine;


/* [0] ���� : TryCatchDescription
		- ����ó��(Exception Handling) : try-catch-finally���� ���.
		- ����(����)
            - ������ ���� : �ڵ��� �ϴٰ� ����� ����.
            - ��Ÿ���� ���� : ���� �����߿� ������ ����.
            - �˰����� ���� : �÷��̾��� ���û��׿� �ùٸ����ʴ� �ൿ�� �ϴ� ����.
		- ����
            try
            {
                // ��ɹ�
                // ...
            }
            catch
            {
                // try �ڵ��� �ȿ� �ִ� ��ɹ��� ���� �� ����(Exception)�� �߻��� ���, ��� ó���� ����
                // ...
            }
*/

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch
        {
            Debug.Log("������ �߻��Ͽ����ϴ�.");
        }
    }
}
