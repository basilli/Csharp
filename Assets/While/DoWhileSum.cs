using UnityEngine;


/* [0] ���� : DoWhileSum
        - dowhile���� �̿��Ͽ� 1���� n(100)������ ���� �߿��� ¦���� ���� ���ϴ� ���α׷��� ����ÿ�.
 */
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 100;
        int sum = 0;    // 1) ����� �����ϴ� ����.
        int i = 1;    // 2) �ʱ��.

        // [2] ����
        do
        {
            i++;    // 3) ������.
            if (i % 2 == 0)    // 4) ¦���Ǻ���.
            {
                sum = sum + i;    // 5) �ݺ����๮.
            }
        } while (i <= n);    // 6) ���ǽ�.

        // [3] ���
        Debug.Log($"1���� {n}������ ¦���� �� : {sum}");
    }
}
