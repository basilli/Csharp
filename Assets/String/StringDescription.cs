using UnityEngine;


/* [0] ���� : StringDescription
		- String Class, StringBuilder Class�� �̿��Ͽ� ���ڿ� �ٷ��.
*/

public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] ���� : ���ڿ� ���� �޼���
        string message = "hello WORLD!!!";
        // [1-2] ���
        Debug.Log(message);
        // [1-3] ��� : �롤�ҹ��ڷ� �ٲٱ�.
        Debug.Log(message.ToUpper());
        Debug.Log(message.ToLower());
        // [1-4] ��� : �ٲ�ġ��.
        Debug.Log(message.Replace("hello", "�ȳ��ϼ���").Replace("WORLD","����"));
    }
}
