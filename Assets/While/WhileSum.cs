using UnityEngine;


/* [0] ���� : WhileSum
        - while���� �̿��Ͽ� 1���� n(100)���� ���� ���ϴ� ���α׷��� ����ÿ�.
 */
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 100;
        int sum = 0;    // 1) ����� �����ϴ� ����.
        int i = 1;  // 2) �ʱ��

        // [2] ����
        while (i <= n)    // 3) ���ǽ�
        {
            sum = sum + i;    // 4) �ݺ����๮
            i++;    // 5) ������
        }

        // [3] ���
        Debug.Log($"1���� {n}������ �� : {sum}");
    }
}
