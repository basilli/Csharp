using UnityEngine;

// ���� score�� 60�� �̻��̸� "�հ�"�̶�� ����� ��.
// score 61��
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int score = 61;

        if (score >= 60);   // ���ǹ��� ���̸� ��� �ȿ� �ִ� ���๮�� ����.
        {
            // [2] ���๮
            Debug.Log("�հ�");
        }
    }
}


/*
    [1] ��� : ���α׷��� �帧(����)�� ���ϴ� ����.
        - ���ǹ�(if-else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� ����.
            - if��
                : ���ǽ��� ���϶��� ���๮�� �����.
                : ���ǽ��� �����̸� ���๮�� ������������.

                // ���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�.
                    if(���ǽ�)
                    {
                     // ���๮1
                     // ���๮2
                     // ...
                    }

                    if(bool)
                    {
                     // ���๮1
                     // ���๮2
                     // ...
                    }
 */