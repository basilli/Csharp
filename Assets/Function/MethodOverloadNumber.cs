using UnityEngine;


/* [0] ���� : MethodOverloadNumber
		- MethodOverload(�޼��� �����ε�) : �Լ� ��������
		- ������ �̸��� �޼����� �Ű������� �޸��ؼ� �������� �����ϴ� ��. �� �̸��� ������ Ÿ���� �ٸ����ؼ� �ҷ��� �� ����.
		- Ŭ������ �������̽� ������ ���� �̸��� �޼��带 ���� �� �����ϴ� �������, �Ű������� ���� �����Ͽ� ������ �� ����.
        - ���� �̸��� �޼��带 ���� �� ������ �� ����.
        - �Ű������� ��, Ÿ��, ������ �����Ͽ� ������ �� ����.
        - ���� �۾��� �پ��� ������� ������ �� ����.
*/

public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : �Ű������� ���ڸ� �Է¹޾� ����ϴ� �Լ�(PrintNumber)
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);
    }
    // [2-1] ���� : int Ÿ���� ������ �Ű������� �Է¹޾� ���. (�Ű������� ���ڸ� �Է¹޾� ����ϴ� �Լ�, PrintNumber)
    void PrintNumber(int number)
    {
        Debug.Log($"Int32 : {number}");
    }

    // [2-2] ���� : long Ÿ���� ������ �Ű������� �Է¹޾� ���.
    void PrintNumber(long number)
    {
        Debug.Log($"Int64 : {number}");
    }

    // [2-3]  ���� : Float Ÿ���� �Ǽ��� �Ű������� �Է¹޾� ���.
    void PrintNumber(float number)
    {
        Debug.Log($"�Ǽ��� : {number}");
    }
}
