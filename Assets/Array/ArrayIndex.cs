using UnityEngine;


/* [0] ���� : ArrayIndex
        - Index : �ε���
        - ���° ��, { } �ȿ� ���� ���� �� ��.
        - ũ�Ⱑ 3�� ������ �迭�� �����ϰ� �ʱ�ȭ �Ͻÿ�.
 */

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int[] numbers = { 1, 2, 3 };		// ) nubmers[0] �� 1, nubmers[1] �� 2, nubmers[2] �� 3 
        int index = 0;      // ) �迭�� �ε����� �����ϴ� ����, �׻� 0���� �ʱ�ȭ �� ��. �� �ε����� ������ 0~n-1(2)�� �� ��.

        // [2] ���
        Debug.Log(numbers[index++]);        // ) nubmers[0] �� 1, index = 1
        Debug.Log(numbers[index++]);        // ) nubmers[1] �� 2, index = 2
        Debug.Log(numbers[index++]);        // ) nubmers[2] �� 3, index = 3

        Debug.Log(numbers[--index]);        // ) index = 2, nubmers[2] �� 3
        Debug.Log(numbers[--index]);        // ) index = 1, nubmers[1] �� 2
        Debug.Log(numbers[--index]);        // ) index = 0, nubmers[0] �� 1
    }
}
