using UnityEngine;


// [0] ���� : else ��ø��
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        char input = '1';

        /*
          [2] ���� �� ���
                intput 'y' �̸�, Yes ���.
                intput 'n' �̸�, No ���.
                intput �� �� ������ �̸�, CANCEL ���.
         */
        if (input == 'y')
        {
            Debug.Log("Yes");
        }
        else // else�� if�� ���� �־�� ��. ȥ�ڼ� ����� �� ����.
        {
            if (input =='n')
            {
                Debug.Log("No");
            }
            else
            {
                Debug.Log("CENCEL");
            }
        }
    }
}
