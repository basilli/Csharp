using UnityEngine;

public class VariablePratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //[1] ���� ����
        int first, second, third;

        //[2] ������ �� ����
        first = 10;
        second = 20;
        third = 30;

        //[3] ���� ���
        Debug.Log(first + "," + second + "," + third);

        //[4] ������ ���ǵ� first~third�� //[1]���� ���ǵ� first~third�� �ߺ��Ǳ⶧���� �̴�� �ϸ� ������ �߹Ƿ�, [3]���� ���ǵ� first~third�� �ٲ�� ��
    }
}


/*
 [Q]
    ���� : first, second, third �����ϰ� �� �����Ͽ� �Ʒ� ���� ���

 [Output]
    10, 20, 30
*/