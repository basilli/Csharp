using UnityEngine;


/* [0] ���� : BerakWhile
        - 1���� 10������ ������ ���� ���ϴ� ���α׷��� ����ÿ�.
        - ���� ��(sum)�� 22(goal)�̻��� ���, �� �̻� ���� ������ ���� ��.
        - while���� �̿��ؼ� ���� ��.
 */
public class BerakWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 10;
        int sum = 0;
        int goal = 22;
        int i = 1;  // ) �ʱ��

        // [2] ����
        while (i <= n)  // ) ���ǽ�
        {
            sum = sum + i;  // ) �ݺ����๮
            if (sum >= goal) // ) ���� ��(sum)�� 22(goal) �̻�
            {
                break;
            }
            i++;    // ) ������
        }

        // [3] ���
        Debug.Log($"1���� {n}������ ������ �� : {sum}");
    }
}
