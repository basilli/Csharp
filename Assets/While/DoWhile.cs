using UnityEngine;


/* [0] ���� : doWhile
        - for���̳� while��ó�� �ݺ����� ����.
        - ����, �ݺ����๮�� 1�� ������.
        - ���ǽ��� true�� ���, �ݺ����� �����ϰ�, false�� ���, �ݺ����� ������.
        - ����
            do
            {
                // �ݺ����๮
            } while(���ǽ�)
        - �۾�����
                ���ǽ�(i=0) �� �� ���
                ������(i=1) �� ���ǽ�(i<3) �� �� ���
                ������(i=2) �� ���ǽ�(i<3) �� �� ���
                ������(i=3) �� ���ǽ�(i<3) ���� �� ����

        - �ȳ��ϼ��並 3�� ����ϴ� ���α׷��� ����ÿ�.
 */
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int i = 0;  // 1) �ʱ��

        // [2] ����
        do
        {
            Debug.Log("�ȳ��ϼ���");    // 2) �ݺ����๮
            i++;    // 3) ������
        } while (i < 3);    // 4) ���ǽ�
    }
}