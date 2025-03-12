using UnityEngine;

/* [0] ���� : ClassDescription
		- C#���� ���� �⺻�� �Ǵ� ����.
		- �ϳ��� �̸����� ���� �ٸ� ������ �����Ϳ� �Լ��� ��� �����ϴ� �׸�(����)
        - ����� ���� ������ ����.
        - ����
            public class (Ŭ���� ��)
            {
            
            }
		- ����Ƽ�̼� Script�� ���� ������ ��, �ϴ��� ���� Scripting �� Empty C# Script�� �⺻������.
		- �Ӽ�(�ʵ�, ������Ƽ)�� ����(�޼���)�� �����ϴ� ������ ������ ���� ������ �繰�� �ڵ�� ǥ���ϴ� ���赵.
		- Ŭ������ ������� ��ü�� ����� ���.
        - �� �� ������ Ŭ������ ���� ������ ���� �����Ͽ� �������� �� Ȯ�强�� �پ.
        - �����͸� �ܺο��� ���� �������� ���ϵ��� ��ȣ�ϰ�, �ʿ��� ��ɸ� ������ �� ����.
        - ���ʿ��� ������ ����� �ʿ��� ������ �����Ͽ� �ڵ��� ���⼺�� ����.
        - ���� Ŭ������ Ȯ��(���)�Ͽ� ���ο� ����� �߰��� �� ����.
*/

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [3] ���� : �޼��� ȣ��.
        Run();      // ) ���� Class�� �޼��� ȣ��.
        ClassDescription.Run();     // ) Class ������ �޼��� ȣ��. (ex. Ŭ�����̸�.�޼���( ) ȣ��)
    }
    // [1] ���� : ClassDescription�̶�� Class�� Run(����) �޼���(�Լ�).
    static void Run()
    {
        Debug.Log("ClassDescription�̶�� Ŭ������ Run( ) �޼���");
    }
}
