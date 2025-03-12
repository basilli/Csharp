using UnityEngine;


/* [0] ���� : IsDemo
		- �� ����(Value Type) : ��ü�� �� ��ü�� ����ִ� ����.
		- ���� ����(Reference Type) : ��ü�� ���� ����ְ�, �� �ٸ� ��ü�� �����ͷ� �ٶ󺸴� ����.
		- Object ������ ���� : Object ������ �������� ��� ������ ������ ���� ����(�Ҵ�) ����.
        - �ڽ�(Boxing) : �� ������ �����͸� ���� ������ �����ͷ� �����ϴ� ��.
        - ��ڽ�(UnBoxing) : ���� ������ �����͸� �� ������ �����ͷ� �����ϴ� ��. �� ĳ����

		- is ������ : ���� ���ϱ�.
            - Ư���������� �ƴ��� ��.
            - Ư���������� ��ȯ�� �����ϸ� true, �ƴҰ�� false.
*/

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] ����
        int i = 1234;
        object o = i;
        Debug.Log(o);
        // [1-2] ����
        object obj = 9874;
        int num = (int)obj;
        Debug.Log(num);
        // [1-3] ����
        object s = "�ȳ��ϼ���.";
        object j = 4567;

        // [2-1] ����
        if (s is string)
        {
            Debug.Log($"[1] {s}�� null�� �ƴϸ�, ���ڿ� �������� ��ȯ�� �����մϴ�.");
        }
        // [2-2] ����
        if (j is int)
        {
            Debug.Log($"[2] {j}�� ���������� ��ȯ�� �����մϴ�.");
        }
    }
}
