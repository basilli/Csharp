using Unity.VisualScripting;
using UnityEngine;


/* [0] ���� : ForSumPractice
        [Q]
            - 1���� 100������ ���� ��, 3�� ��� �Ǵ� 4�� ����� ���ؼ� ���ϴ� ���α׷��� ����ÿ�.
        [output]
            - ���� { }
 */
public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 100;
        int sum = 0;

        // [2] ����
        for (int i = 1; i < n + 1; i++)
        {
             // [2-1] 3�� ��� �Ǵ� 4�� ��� �� �ߺ��Ǵ� ���� �����ϰ� �����.
             if (i%3 == 0 || i%4 == 0)
             {
                 sum = sum + i;
             }

            /*
            // [2-2] 3�� ��� �Ǵ� 4�� ��� �� �ߺ��Ǵ� ���� �����ؼ� �����.
            if (i % 3 == 0)
            {
                sum = sum + i;
            }
            if (i % 4 == 0)
            {
                sum = sum + i;
            }
            */
        }

        // [3] ���
        Debug.Log($"1���� 100������ ���� ��, 3�� ��� �Ǵ� 4�� ����� ���� {sum}�̴�. ");
    }
}


