using UnityEngine;


/* [0] ���� : EnumerationDescription
		- Enumeration(������) : �ϳ��� �̸����� ���� �����ִ� ���� ���� ���� ������� ����.
		- ����
            enum (enum �̸�)
            {
                �����,
                �����,
                �����,
                ETC...
            }
		- ���õ� ������� ������ �����ϴ� ������ Ÿ�� �� ����, ����, ���� ���� ��Ÿ�� �� enum�� ����ϸ� �� �������̰� �������� ������.
        - ���� ������ ������ ������� ����.
        - �⺻������ 0���� �����ϴ� ���� ���� �ڵ����� �Ҵ���.
        - Ư�� ���³� �ɼ��� �ǹ� �ִ� �̸����� ǥ���� �� ����.
        - �ڵ��� �������� ������������ ������..
*/

// [1] ���� : �켱������ �����ϴ� ������ ����(����, �����). �� ����� ���� ������ ����.
enum Priority
{ 
    High,
    Normal,
    Low,
}

public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ���� : ������ ���� ���� �� �ʱ�ȭ. �� ������ �������� ����Ǵ� ���� ���ǿ��� ������� ������� ������.
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        // [3] ���
        Debug.Log($"{high}, {normal}, {low}");
    }
}
