using UnityEngine;


/* [0] ���� : IfElseIfElse
    - ���ǽ� 1)�� ���� ���.
        : ���� �� ���๮ 1 �� ���๮ 4
    - ���ǽ� 1)�� �����̰�, ���ǽ� 2)�� ���� ���.
        : ���� �� ���๮ 2 �� ���๮ 4
    - ���ǽ� 1)�� �����̰�, ���ǽ� 2)�� ������ ���.
        : ���� �� ���๮ 3 �� ���๮ 4
    - ���ǽ� 1)�� ���̰�, ���ǽ� 2�� ���� ���.
        : ???
 */
public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] ����
              - number1, number2 ���� �޴´�.
              - 1) number1�� Ŭ ���, "number1�� Ů�ϴ�." ���.
              - 2) number2�� Ŭ ���, "number2�� Ů�ϴ�." ���.
              - 3) �������� "�� ���� ũ�Ⱑ �����ϴ�." ���.
         */
        int number1 = 10;
        int number2 = 10;

        // [2] ����
        // ���ǽ� 1)
        if (number1 > number2)
        {
            // ���๮ 1)
            Debug.Log("number 1�� Ů�ϴ�.");
        }
        // ���ǽ� 2)
        else if (number2 > number1) 
        {
            // ���๮ 2)
            Debug.Log("number 2�� Ů�ϴ�."); 
        }
        // ���ǽ� 3)
        else
        {
            // ���๮ 3)
            Debug.Log("�� ���� ũ�Ⱑ �����ϴ�."); 
        }
    }
}
