using UnityEngine;


/* [0] ���� : BreakInfiniteLoop
        - break�� ���ѷ����� �������� �� ����.
        - nubmer�� 5 �̻��� ���, while���� ���� �Ұ�.
        - 
 */
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int number = 0;

        // [2] ����
        while (true)    // 1) ���ѷ���.
        {
            Debug.Log(number);  // 2)�ݺ����๮

            number++;
            if (number >= 5)
            { 
                break;
            }
        }
    }
}
