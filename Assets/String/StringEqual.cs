using UnityEngine;


/* [0] ���� : StringEqual
		- ���ڿ� ���ϱ�
*/

public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        string userName = "RedPlus";
        string inputName = "redPlus";

        // [2-1] ��� : ������( == )�� �̿�.
        if (userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1] �����ϴ�.");
        }
        // [2-2] ��� : string.Equal( ) �޼��带 �̿�.
        if (string.Equals(userName, inputName, System.StringComparison.InvariantCultureIgnoreCase))
        {
            Debug.Log("[2] �����ϴ�.");
        }
    }
}
