using UnityEngine;


/* [0] ���� : ForSumEven
        - 1���� n(10)������ ���� �� ¦���� ���� ���ϴ� ���α׷��� ����ÿ�.
        - 2+4+6...+8+10 = ???
 */
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 10;
        int sum = 0;

        // [2] ����
        for (int i = 1; i < n + 1; i = i++)
        {
            sum = sum + i;
        }

        // [3] ���
        Debug.Log($"1���� 10������ ���� �� ¦���� ���� {sum} �̴�.");
    }
}


/*
            // [1] ����
           int n = 10;
           int sum = 0;

            // [2] ����
           for (int i = 1; i < n + 1; i = i++)
           {
                sum = sum + i;
           }

           // [3] ���
           Debug.Log($"1���� {n}������ ���� {sum} �̴�.");
 */

/*

 */