using UnityEngine;


/* [0] ���� : FuctionAbs
		- abs(����)�� ���ϴ� �Լ� �����.
		- -5�� ������ 5, 143�� ������ 143
*/
public class FuctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ���� : -21�� ������ ���ϰ� ����ϱ�.
        int number = -21;
        int abs = Mathf.Abs(number);

        /* [A]
        int abs = Abs(number);
        */

        // [3] ���
        Debug.Log($"{number}�� ������ {abs} �̴�.");

    }
    // [1] ���� : �Ű������� ���� ������ ������ ��ȯ�ϴ� �Լ�.
    int Abs(int num)
    {
     return (num < 0) ? -num : num;

        /* {A]
        if (num < 0)
        {
        return -num;
        }
        else
        {
        return num;
        }
        */
    }
}
