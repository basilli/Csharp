using UnityEngine;


/* [0] ���� : ContinueDemo
        - 1���� 100������ ���� �߿��� 3�� ����� ������ ���� ���ϴ� ���α׷��� ������.
 
 */
public class ContinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 100;
        int sum = 0;

        // [2] ����
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)     // ) 3�� ��� �Ǻ���
            {
                continue;       // ) continue�� for���� �ڿ� �ִ� ���� �Ϲ�����. (�� �ؿ� ���� ���, ȿ���� X)
            }
            sum += i;
        }

        // [3] ���
        Debug.Log($"1���� {n}������ ���� �߿��� 3�� ����� ������ ���� {sum}�̴�.");
    }
}