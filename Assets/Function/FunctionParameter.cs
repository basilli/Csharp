using UnityEngine;


/* [0] ���� : FunctionParameter
		- Parameter : �Ű�����
*/
public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] �Ű������� �ִ� �Լ� ���.
        showmessage("�ȳ��ϼ���.");
        showmessage("�ȳ�");
    }

    /* [1] ����
        - �Ű������� �ִ� �Լ� ����.
        - �Ű������� ���� ���� ���ڿ��� ���.
     */
    void showmessage(string message)
    {
        Debug.Log(message);
    }
}
