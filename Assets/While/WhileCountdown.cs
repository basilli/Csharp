using UnityEngine;

/* [0] ����
        - 1,2,3,4,5(��������) & 5,4,3,2,1(��������)
 */

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : 1~5���� 1�� ����(��������)
        int i = 1;  // 1) �ʱ��

        // [2] ����
        while (i <= 5)  // 2) ���ǽ�
        {
            Debug.Log($"ī��Ʈ�ٿ� : {i}");  // 3) �ݺ����๮
            i++;    // 4) ������
        }

        Debug.Log(" ========================================================================================================================================== ");

        // [1] ���� : 1~5���� 1�� ����(��������)
        int j = 5;  // 1) �ʱ��

        // [2] ����
        while (j >= 1)  // 2) ���ǽ�
        {
            Debug.Log($"ī��Ʈ�ٿ� : {j}");  // 3) �ݺ����๮
            j--;    // 4) ������
        }


    }



}
