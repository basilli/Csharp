using UnityEngine;


/* [0] ���� : StructureNote
		- ���� �����͸� �����ϴ� ����ü�� ����ÿ�.
*/

// [1] ����
struct BusinessCard
{
    public string name;     // ) ���̸�
    public int age;     // ) ������
    public string address;      // ) ���ּ�
}

public class StructureNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] ���� : ����ü ������ ���� ����.
        BusinessCard mycard;

        // [2-2] ���� : ����ü�� �����ִ� ������ �ʱ�ȭ.
        mycard.name = "ȫ�浿";
        mycard.age = 20;
        mycard.address = "����Ư���� ������";

        // [3] ���
        Debug.Log($"�̸� : {mycard.name}, ���� : {mycard.age}, �ּ� : {mycard.address}");
    }
}
