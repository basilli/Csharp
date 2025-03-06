using UnityEngine;


/* [0] ���� : ForFactorial(!)
        - 1���� n������ �ڿ����� ��� ���ϴ� ��.
        - 1! = 1
        - 2! = 1*2
        - 3! = 1*2*3
        - 4! = 1*2*3*4
        - n! = 1*2*3* ... (n-1)*n

        - 4! ���� ���ϴ� ���α׷��� ����ÿ�.
 */
public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int n = 10;
        int fact = 1;

        // [2] ����
        for (int i = 1; i < n + 1; i++)

        {
            fact = fact * i;
        }

        // [3] ���
        Debug.Log($"{n}!�� ���� {fact}�̴�.");
    }
}
