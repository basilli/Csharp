using UnityEngine;

// &&, ||
public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int number = 1234;

        /* [2] 2������ ���ǽ�
               - number�� 1234�� ������?
               - number�� 1000 �̻��ΰ�?
               
               - 2���� ������ ��� ����(&&)�ϸ� �½��ϴ� ���.
         */
        if (number == 1234 && number >= 1000);
        {
            Debug.Log("�½��ϴ�.");
        }

        /* [3] 2������ ���ǽ�
               - number�� 1234�� ������?
               - number�� 1000 �����ΰ�?
              
               - 2���� ������ �ϳ��� ����(||)�ϸ� ���๮ ����. 
         */
        if (number == 1234 || number <= 1000) ;
        {
            Debug.Log("�ϳ��� ���̸� ��");
        }
    }
}
