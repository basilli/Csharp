using UnityEngine;


/* [0] ���� : SwitchNote
        - if(���ǽ�)�� ���� �������� �Ǻ��� �� ����.
            ex) if ( )
                {
                ���๮ 1
                }
                else
                {
                ���๮ 2
                }
        - switch(���ǽ�)�� Data�� ���� �Ǻ���.
            ex) switch ( )
                {
                case 1��:
                ���๮ 1
                break;
                case 2��:
                ���๮ 2
                break;
                case 3��:
                ���๮ 3
                break;
                defalt : ��� case�� �ƴ� ���, break;
                ���๮ 4
                break;
                }
        - int x = 2;
          (1) �� (3) �� (4)
        - int x = 1;
          (1) �� (2) �� (4)
 */
public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int x = 1; // (1)

        // [2] ����
        switch (x)
        {
            case 1: // (2)
                Debug.Log("x�� 1 �Դϴ�. ");
                break;
            case 2: // (3)
                Debug.Log("x�� 2 �Դϴ�. ");
                break;
        }

        // [3] ���
        Debug.Log("���α׷� ����. "); // (4)
    }
}
