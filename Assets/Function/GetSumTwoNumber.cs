using UnityEngine;


/* [0] ���� : GetSumTwoNumber
		- �� ���� ���� ���ϴ� �Լ� �����.
*/
public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [2] ����
                - �� ����(3,4)�� ���� ��ȯ���� �޾� ���.
         */
        int result = GetSum(3, 4);
        Debug.Log(result);
    }
    /* [1] ����
            - �� ���� ���� ���ϴ� �Լ� ����� : �Ű�����, ��ȯ���� �̿�.
            - �Ű������� ���� �� ������ ���� ��ȯ�ϴ� �Լ� ����.
     */
    int GetSum(int x, int y)
    {
        return (x + y);
        /* [A]
            // int sum = x + y;
            // return sum;
         */
    }
}
