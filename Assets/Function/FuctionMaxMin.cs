using UnityEngine;


/* [0] ���� : FuctionMaxMin
		- [Q]
            - �Ű������� �Է¹��� �� ���� ���� �� ū ���� ��ȯ�ϴ� �Լ��� ����ÿ�.
            - �Ű������� �Է¹��� �� ���� ���� �� ���� ���� ��ȯ�ϴ� �Լ��� ����ÿ�.
            - 3, 5�� �Է��Ͽ� ū ���� ����Ͻÿ�.
            - -3, -5�� �Է��Ͽ� ���� ���� ����Ͻÿ�.
        - [output]
            - 3�� 5 �� ū ���� (��ȯ��) �Դϴ�.
            - -3�� -5 �� ���� ���� (��ȯ��)�Դϴ�.
*/
public class FuctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 3, 5�� �Է��Ͽ� ū ���� ����Ͻÿ�.
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5 �� ū ���� {max} �Դϴ�.");

        // [4] -3, -5�� �Է��Ͽ� ���� ���� ����Ͻÿ�.
        /*
        int min = GetMin(-3, -5);
        Debug.Log($"3�� 5 �� ���� ���� {min} �Դϴ�.");
        */
    }
    // [1] �Ű������� �Է¹��� �� ���� ���� �� ū ���� ��ȯ�ϴ� �Լ��� ����ÿ�.
    int GetMax(int x, int y)
    {
        int maxValue;
        if (x > y)
        {
            maxValue = x;
        }
        else
        {
            maxValue = y;
        }
        return maxValue;

        /* [A] 3�� ������
            int maxValue = (x > y) ? x : y;
            return maxValue;
         or
            return (x > y) ? x : y;
         or
            if (x > y)
            {
            return x;
            }
            else
            {
            return y;
            }
         */

        // [3] �Ű������� �Է¹��� �� ���� ���� �� ���� ���� ��ȯ�ϴ� �Լ��� ����ÿ�.
        int GetMin(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }





    }
}
