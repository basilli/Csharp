using UnityEngine;


/* [0] ���� : ArrayForEach
		- foreach : �迭�� ����� �������� ���� ������� �����ͼ� ���.
        - �迭�� �����͸� ó������ ������ ��������, �� �̻� ������ �� ���� ��� �ݺ����� ������.
        - ����
            foreach (�迭�� ������Ÿ�� �����̸� in �迭���� �̸�)
            {
                // �ݺ����๮
            }

		- �迭 ��ҵ��� ���� ��� �����ͼ� ������ ���ϴ� ���α׷��� ����ÿ�.
*/
public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        float[] arr = { 10.5f, 20.1f, 30.3f };
        float sum = 0f;

        // [2] ����
        /*
                // [2-1] for ��
                for (int i = 0; i < 3; i++)
                {
                    sum = sum + arr[i];     // ) �迭�� �׻� �ݺ����� ���� ����.
                }
        */
        // [2-2] foreach ��
        foreach (float f in arr)        // ) arr�� �ִ� ������ �� ���� �տ� �ִ°� f�� ������.
        {
            sum = sum + f;      // ) �ݺ����๮
        }

        // [3] ���
        Debug.Log($"�� ���� {sum}�Դϴ�.");
    }
}
