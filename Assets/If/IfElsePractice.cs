using UnityEngine;

// [0] ���� : IfElsePractice ��������
public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int score = 85;
        char a = '��';
        char b = '��';
        char c = '��';
        char d = '��';

        // [2] ���� �� ���
        if (score >= 90)
        {
            Debug.Log($"{a}�޴��� �����Ͽ����ϴ�.");
        }
        else
        {
            if (score >= 80)
            {
                Debug.Log($"{b}�޴��� �����Ͽ����ϴ�.");
            }
            else
            {
                if (score >= 70)
                {
                    Debug.Log($"{c}�޴��� �����Ͽ����ϴ�.");
                }
            }
            Debug.Log($"{d}�޴��� �����Ͽ����ϴ�.");
        }
    }
}



/*
  [Q]
    - score : 85��
    - 90 �̻��� ���, �ݸ޴� ���.
    - 80 �̻��� ���, ���޴� ���.
    - 70 �̻��� ���, ���޴� ���.
    - ��������, ��޴� ���.
    [output]
    ( )�޴��� �����Ͽ����ϴ�.
 */

/*
  [A]
{
        // [1] ����
        int score = 85;

        // [2] ���� �� ���
        if (score >= 90)
        {
            Debug.Log($"�ݸ޴��� �����Ͽ����ϴ�.");
        }
        else
        {
            if (score >= 80)
            {
                Debug.Log("���޴��� �����Ͽ����ϴ�.");
            }
            else
            {
                if (score >= 70)
                {
                    Debug.Log("���޴��� �����Ͽ����ϴ�.");
                }
            }
        }
    }
 */

/*
  [A]
    {
        // [1] ����
        int score = 85;
        char a = '��';
        char b = '��';
        char c = '��';
        char d = '��';

        // [2] ���� �� ���
        if (score >= 90)
        {
            Debug.Log($"{a}�޴��� �����Ͽ����ϴ�.");
        }
        else
        {
            if (score >= 80)
            {
                Debug.Log($"{b}�޴��� �����Ͽ����ϴ�.");
            }
            else
            {
                if (score >= 70)
                {
                    Debug.Log($"{c}�޴��� �����Ͽ����ϴ�.");
                }
            }
            Debug.Log($"{d}�޴��� �����Ͽ����ϴ�.");
        }
    }
}
 */