using UnityEngine;


/* [0] ���� : ForSum
        - 1���� 20������ ���� ���ϴ� ���α׷� ����.
        - 1+2+3+ ... +19+20

        - 1���� n������ ���� ���ϴ� ���α׷� ����.
        - 1+2+3+ ... +(n-1)+n
 */
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 100;
        int sum = 0;
        for (int i = 1; i < n+1; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"���� {sum}");
    }
}

/* [A]
     {
        // [1] ����
        int sum = 0;
        for (int i = 1; i < 21; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"���� {sum}");
    }
 */
