using System.Runtime.CompilerServices;
using UnityEngine;


/* [0] ���� : ArrayDescription
        - Array(�迭) : �ϳ��� �̸����� ���� ������ ������ ������ ������ ���� �׸�.
        - Variable(����) : ���α׷����� ����ϴ� �����͸� ������ ���� �׸�.
        - // ������Ÿ��[ ] ������(�̸�);
 */
public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 10;
            // [1-1] �迭����
            int[] numbers;
            // [1-2] �迭�� ��Ҽ� ����(�׸��� ���� �� ũ�� ����)
            numbers = new int[n];   // ) 0~n-1
            // [1-3] �迭�� ���� �� ����(�ʱ�ȭ)
            numbers[0] = 3840;
            numbers[1] = 2160;
        // [1-4] �迭�� ���
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);
    }
}
