using UnityEngine;

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // [1] ���� : ���� x�� 10�̸� x�� 10�Դϴ�. ���.
        int x = 10;
             /*
             if (x�� 10�̸�)
             { 
             x�� 10�Դϴ�. ���.
             }
             */
        // [1-2] ����
        if (x == 10)
        {
            Debug.Log("x�� 10�Դϴ�.");
        }



        // [2] ���� : ���� x�� 20�� �ƴϸ� x�� 20�� �ƴմϴ�. ���.
              /*
              if (x�� 20�� �ƴϸ�)
              { 
              x�� 20�� �ƴմϴ�. ���.
               }
               */
        // [2-1] ����
        if (x != 20)
        {
            Debug.Log("x�� 20�� �ƴմϴ�.");
        }
    }
}
