using UnityEngine;


/* [0] ���� : FunctionDescription
		- Function(�Լ�) = Method(�޼���)
		- �ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ��.
        - �Լ��� ����
		    - �����Լ� : ���(C#)���� �����ϴ� �Լ� or ����Ƽ���� �����ϴ� �Լ�.
		    - ������Լ� : �����ڰ� ����� �Լ�.
        - �Լ��� ���� : �Է� �� ó��(����) �� ���
        - �Լ�(�޼���)�� ����
            [1] �Լ� ���� (��ɱ���)
            [2] �Լ� ȣ�� (��ɻ��)\
        - ����
            - �Ű������� ���� �Լ�
                void �Լ��̸� ( )
                {
                    // �ϳ� �̻��� ��ɹ�
                    // ...
                }
            - �Ű������� �ִ� �Լ�
                void �Լ��̸� (�Ű�����)
                {
                    // �ϳ� �̻��� ��ɹ�
                    // ...
                }
            - ��ȯ���� �ִ� �Լ�
                (������Ÿ��) �Լ��̸� (�Ű�����?)        // ) �Ű������� �������� �������� ����.
                {
                    // �ϳ� �̻��� ��ɹ�
                    // ...
                }
                    retun ����(��);        // ) ��ȯ�ϴ� ������ ���� �Լ�
*/
public class FunctionDescription : MonoBehaviour
{
    // [1] ���� : Show �Լ�(�޼���) ����
    void Show()
    {
        Debug.Log("Hello World!!!");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] Show �Լ� ȣ��
        Show();
    }
}
