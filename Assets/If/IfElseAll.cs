using UnityEngine;


// [0] ���� : IfElseAll
public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] ����
               - �ϳ��� ������ �Է� �޾Ƽ� ¦������ Ȧ������ �Ǻ��� ��.       
         */
        int number = 21;

        // [2-1] ���� : ¦�� �Ǻ���.
        if (number % 2 == 0)
        {
            Debug.Log($"{number}�� ¦���Դϴ�. ");
        }

        // [2-2] ���� : Ȧ�� �Ǻ���.
        if (number % 2 != 0)
        {
            Debug.Log($"{number}�� Ȧ���Դϴ�. ");
        }
        else
        {
            Debug.Log($"{number}�� ¦���Դϴ�. ");
        }

        // [2-3] ���� : 3�� ���, 5�� ���, 7�� ��� �Ǻ���.
        if (number % 3 == 0)
        {
            Debug.Log($"{number}�� 3�� ����Դϴ�. ");
        }
        else if (number % 5 == 0)
        {
            Debug.Log($"{number}�� 5�� ����Դϴ�. ");
        }
        else
        {
            Debug.Log($"{number}�� 7�� ����Դϴ�. ");
        }
    }
}
