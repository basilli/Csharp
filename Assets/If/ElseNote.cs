using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            // ���๮1
            Debug.Log("���ǽ��� ���� ���, ���๮1�� �����մϴ�.");
        }
        else
        {
            // ���๮2
            Debug.Log("���ǽ��� ������ ���, ���๮2�� �����մϴ�.");
        }
    }
}



/*
  [1] else�� ����
                    : ���� ���ǽ��� ���� ���, ���๮1�� �����մϴ�. ���๮2�� �������� �ʴ´�.
                    : ���� ���ǽ��� ������ ���, ���๮1�� �������� �ʽ��ϴ�. ���๮2�� �����Ѵ�.

    if(���ǽ�)
    {
     // ���๮1
    }
    else
    {
     // ���๮2
    }
     // ���๮ 3

  [2] else�� ����
        - ���ǽ��� ���� ���, ���๮1 �� ���๮3 ������ ����ȴ�.
        - ���ǽ��� ������ ���, ���๮2 �� ���๮3 ������ ����ȴ�.


 */