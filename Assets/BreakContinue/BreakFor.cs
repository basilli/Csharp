using UnityEngine;


/* [0] ���� : BreakFor
        - �ݺ���(for, while...)���� { }�� ���������� ��ɹ�.
        - �ݺ��� �ȿ��� break;���� ���� ���, ��� �ݺ����� ���� ������.

        - �ȳ��ϼ��並 5�� ����ϴ� ���α׷��� ����ÿ�. ��, i�� 2�϶� for���� �����Ͻÿ�.

        - �۾�����
                ���ǽ�(i=0) �� ���ǽ�(i<5) �� �� ���
                ���ǽ�(i==2) ���� �� ������(i=1) �� ���ǽ�(i<5) �� �� ���
                ���ǽ�(i==2) ���� �� ������(i=2) �� ���ǽ�(i<5) �� �� ���
                ���ǽ�(i==2) �� �� break; �� for�� ����
                break;�� ��ġ�� ���� ����Ǵ� ������ �޶���
          
 */
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("�ȳ��ϼ���");

            if (i == 2)
            {
                break;
            }
        }
    }
}
