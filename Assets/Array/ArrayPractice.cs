using UnityEngine;


/* [0] ���� : ArrayPractice
		- [Q]
            - 3�� 3���� 2���� �迭�� ����ÿ�.
            - �迭�� ���� ��� ���� �ε����� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����Ͻÿ�
		    - �����ϴ� ����� ���� for���� ����Ͻÿ�. 
		- [output]
            - arr[0,0] : 1
            - arr[0,1] : 0
                ...
            - arr[2,2] :1
		        1, 0, 0
                0, 1, 0
                0, 0, 1
*/
public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        // [1-1] 2���� �迭 : 3�� 3��
        int[,] arr = new int[3,3];
        // [1-2] �迭�� ����
        Debug.Log($"�迭�� ���� : {arr.Length}");
        // [1-3] 2���� �迭 ���
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)     // ) ��� ���� �ε����� ������ 1
                {
                    arr[i, j] = 1;
                }
                else     // ) ��� ���� �ε����� Ʋ���� 0
                {
                    arr[i, j] = 0;
                }
            }
        }

        // [2] ���
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"arr[{i},{j}] : {arr[i, j]}");
            }
        }

    }
}


/* [A]
    // [1] ����
        // [1-1] 2���� �迭 ���� : ������
        int[][] intArray = new int[3][];
        // [1-2] 2���� �迭 ���� + �ʱ�ȭ
        intArray[0] = new int[3] { 1, 0, 0 };
        intArray[1] = new int[3] { 0, 1, 0 };
        intArray[2] = new int[3] { 0, 0, 1 };
        // [1-3] �迭�� ����
        Debug.Log($"�迭�� ���� : {intArray.Length}");
        // [1-4] 2���� �迭 ���
        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log(intArray[i][j]);
            }
        }
 
 */


/* [B]
    // [1] ����
        // [1-1] 2���� �迭 ���� + ��Ҽ� ����(����) + �ʱ�ȭ
        int[,] intArray = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
        // [1-2] �迭�� ����
        Debug.Log($"�迭�� ���� : {intArray.Length}");
        // [1-3] ���
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }
 */