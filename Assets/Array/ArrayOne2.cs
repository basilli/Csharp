using UnityEngine;


/* [0] ���� : ArrayOne2
 */
public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        // [1-1] �迭���� + ��Ҽ�(���� �� ũ��) ���� + �� �ʱ�ȭ�� ���ÿ� ����.
               // int[] intArray = new int[3] { 1, 2, 3 };
        // [1-2] �迭���� + �� �ʱ�ȭ�� ���ÿ� ����.
               // int[] intArray = new int[] { 1,2,3,4 };     // ) new int[]�� ���� �����ʰ� { }�� �Է��� ����� ���� ������.
        // [1-3] �迭���� + �� �ʱ�ȭ�� ���ÿ� ����.
             int[] intArray = { 1, 2, 3, 4 };

        // [2] ���
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}��° ���� ���� : {intArray[i]} �̴�.");
        }
    }
}
