using UnityEngine;


/* [0] ���� : WhileSumEven
        - while���� �̿��Ͽ� 1���� n(100)������ ���� �߿��� ¦���� ���� ���ϴ� ���α׷��� ����ÿ�.
 */
public class WhileSumEven : MonoBehaviour
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
            if (i % 2 == 0)   // 4) ¦�� �Ǻ���
            {
             sum = sum + i;    // 5) �ݺ����๮
            }
            i++;    // 6) ������
        }

        // [3] ���
        Debug.Log($"1���� {n}������ ¦���� �� : {sum}");
    }
}
