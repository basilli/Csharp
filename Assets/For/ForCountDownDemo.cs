using UnityEngine;


/* [0] ���� : ForCountDownDemo
        - 1,2,3,4,5(��������) or 5,4,3,2,1(��������)
        - 5,4,3,2,1(��������)
 */
public class ForCountDownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        for (int n = 0; n < 5; n++)
        {
            Debug.Log($"���� Countdown : {5-n}");
        }
    }
}


/* [A]
         // [1-1] ���� : ��������
        for (int i = 1; i < 5 + 1; i++)
        {
            Debug.Log($"���� Countdown : {i}");
        }

        Debug.Log("----------------------------------------------------------");

        // [1-2] ���� : ��������
        for (int i = 5; i > 1 - 1; i--)
        {
            Debug.Log($"���� Countdown : {i}");
        }
 */
