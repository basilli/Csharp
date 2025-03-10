using UnityEditor.PackageManager;
using UnityEngine;


/* [0] ���� : DefaultParameter
		- �⺻ �Ű����� or ������ �Ű�������� ��.
		- �Ű������� ������ ��, ���ÿ� �ʱ�ȭ�� ��.
        - ������ �Ű������� �Լ� ȣ�� �� ������ �����ϸ�, ������ �ʱ��� ���� �����.
*/
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        // [2-1] ���� : �Ű������� ���� �Լ� ȣ��.
        PrintMessage();
        // [2-2] ���� : �Ű������� �ִ� �Լ� ȣ��.
        string error = "�����";
        PrintError(error);
        // [2-3] ���� : ��ȯ���� �ִ� �Լ� ȣ��.
        string errorLog = PrintLog();
        Debug.Log(errorLog);
        */
        // [2-4] ���� : ������ �Ű�����.
        PrintError("�����", 4);
        PrintError("�����");
    }
    // [1] ���� :  Message�� 3�� ����ϴ� �Լ��� ����ÿ�.
    void PrintMessage()
    {
        string message = "�����";
        Debug.Log(message);
;    }
    void PrintError(string message, int level = 1)
    {
        Debug.Log($"���� : {message}, ������ : {level}");
    }
    string PrintLog()
    {
        string log = "����� �α�";
        return log;
    }
}
