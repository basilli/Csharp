using UnityEngine;

// ���� score�� 60�� �̻��̸� "�հ�"�̶�� ����� ��.
// �ƴϸ� "���հ�"�̶�� ���.
// score 61��
public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int score = 59;

        if (score >= 60)    // [2] ���ǽ� 01 : ���� score�� 60�� �̻��̸� "�հ�"�̶�� ����� ��.
        {
            Debug.Log("�հ�");
        }
        else    // [3] ���ǽ� 02 : �ƴϸ� "���հ�"�̶�� ���.
        {
            Debug.Log("���հ�");
        }

        Debug.Log("����");   // [4] ����.
    }
}


/*
    int score = 59; : [1] �� [3] �� [4]
    int score = 61; : [1] �� [2] �� [4]
 */