using UnityEngine;


/* [0] ���� : ArrayTwo3
		- ������ �迭 : �迭�� ���̰� ������.
*/

public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        // [1-1] 2���� �迭 ���� : �������ϰ�� ù��° ��Ҽ�(ũ��)�� ����.
        int[][] intArray = new int[2][];       // ) = int[,] intArray;
        // [1-2] 2���� �迭 (�ι�°)��Ҽ�(ũ��) ���� + �ʱ�ȭ : ���� ���� ����.
        intArray[0] = new int[3] { 1,2,3 };       // ) [0]�� ���� ����Ŵ.
        intArray[1] = new int[2] { 4,5 };       // ) [1]�� ���� ����Ŵ.
        // [1-3] �迭�� ����
        Debug.Log($"�迭�� ���� : {intArray.Length}");       // ) �迭�� ���̰� 2�� ���� �� �������� ��� [1-1]���� new int [2][]���� [2]�� ����Ŵ.
        // [1-4] 2���� �迭 ���
        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log(intArray[i][j]);
            }
            Debug.Log("========================");
        }
    }
}
