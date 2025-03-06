using UnityEngine;


// [0] ���� : ElseIf
public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] ����
               - score�� 90�� �̻��� ��� A.
               - score�� 80�� �̻��� ��� B.
               - score�� 70�� �̻��� ��� C.
               - score�� 60�� �̻��� ��� D.
               - �� ���� ��� F.
         */
        int score = 99;
        char grade = 'A';

        // [2] ����
        if (score >= 90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        // [3] ���
        Debug.Log($"{grade} ����");
    }
}
