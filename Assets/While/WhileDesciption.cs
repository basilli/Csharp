using UnityEngine;

/* [0] ���� : WhileDesciption (�ݺ���)
        - ���ǽ��� true�� ���, �ݺ����� �����ϰ�, false�� ���, �ݺ����� ������.
        - ���ǽ�(��) �� �ݺ��� ���� �� ���ǽ�(��) �� �ݺ��� ���� �� ���ǽ�(����) �� while
        - ����
            while(���ǽ�)
            {
                // �ݺ����๮
                // ���ǽĿ� ���� ���� ������
            }
        - for�� Ȱ���� �ȳ��ϼ��並 3�� ����ϴ� ���α׷� ����.
                for(�ʱ��; ���ǽ�; ������)
                for(int i = 0; i < 3; i++) �� �ݺ�Ƚ�� : 3
                for(int i = 1; i <= 4; i++) �� �ݺ�Ƚ�� : 4-1
                for(int i = 1; i <= 3; I++) �� �ݺ�Ƚ�� : 3-1+1

        - �۾�����
                ���ǽ�(i=0) �� �� ���
                ������(i=1) �� ���ǽ�(i<3) �� �� ���
                ������(i=2) �� ���ǽ�(i<3) �� �� ���
                ������(i=3) �� ���ǽ�(i<3) ���� �� ����
 */

public class WhileDesciption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int i = 0;  // 1) �ʱ��

        // [2] ����
        while (i < 3)    // 2) ���ǽ�
        {
            Debug.Log("�ȳ��ϼ���");    // 3) �ݺ����๮
            i++;    // 4)������
        }
    }
}
