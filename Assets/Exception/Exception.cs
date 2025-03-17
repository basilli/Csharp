using UnityEngine;


/* [0] ���� : Exception
*/


public class Exception : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* 
        // [1] ���� : Exception Ŭ������ �̿��Ͽ� ���ܳ��� ����ϱ�.
        [A]
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);      // ) ������ ������ ��ü�� ����Ǿ�, �޼����� ��µ�.
        }
        */

        // [2-1] ����
        string inputNumber = "3.14";
        int number = 0;

        // [2-2] ���� �� ���
        try
        {
            number = System.Convert.ToInt32(inputNumber);
            Debug.Log($"�Է��� ���� {number} �Դϴ�.");
        }
        catch (System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}�� �����̾�� �մϴ�.");
        }
    }
}
