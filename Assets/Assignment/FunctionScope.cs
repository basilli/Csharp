using UnityEngine;


/* [0] ���� : FunctionScope
		- ��������, ��������
*/

public class FunctionScope : MonoBehaviour
{
    // [1] ���� : ��������
    string message = "��������";        // ) �ʵ�, �ɹ� ������� �θ�. �� � �Լ����� ������ �ʴ� ����.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [3] ���
        ShowMessage();
        PrintMessage();
        Debug.Log(message);

        // [2-1] ���� : msg�� ����ϴ� �Լ�
        void ShowMessage()
        {
            string message = "��������";        // ) �̸��� ���� ���, ���������� ���� ����. �� �ش� �ڵ�� �ȿ����� ����� �� ����.
            Debug.Log(message);
        }
    }
    // [2-2] ����
    void PrintMessage()
    {
        Debug.Log(message);     // ) ���� �ִ� string msg�� ���� �ִ� �ڵ�� �ȿ����� �����ϱ⶧���� NG�� ��. �� ���������� �˾ƺ�
    }
}
