using UnityEngine;
using UnityEngine.Rendering;

// ���๮ : �ܹ�(1��), ����(2�� �̻�)
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [0] ���� ���ǽ��� ���̸� { } �ȿ� �ִ� ���๮�� �����϶�.
        /*
         if(���ǽ�)
         {
            //���๮1
            //���๮2
            //...
         }
         */

        // [1] �ܹ� : ���๮�� 1���� ��.
        if (1 == 1) ;
        {
            Debug.Log("�ܹ� 1");
        }

        // [1-2] if���� { }�� ������ �Ǹ� �ٷ� �Ʒ��ִ� 1�ٸ� ����.
        if (1 == 1) ;
        Debug.Log("�ܹ� 2");

        // [1-3] if���� ���ٷ� ����.
        if (1 == 1) Debug.Log("�ܹ� 3");

        // [2] ���� : ���๮�� 2�� �̻��� ��.
        if (1 == 1)
        {
         Debug.Log("���� 1");
         Debug.Log("���� 2");
        }

    }
}

