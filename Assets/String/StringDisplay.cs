using UnityEngine;


/* [0] ���� : StringDisplay
		- ���ڿ� ���� ���(���ڿ� �ٹ̱�)
            - string ���ϱ�(+) ������ �̿�.
            - string.Format( ) �޼��带 ���.
            - ���ڿ� ������ ���.
*/

public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        var displayName = "";
        var firstName = "�浿";
        var lastName = "ȫ";

        // [2-1] ��� : string ���ϱ�(+) ������ �̿�.
        displayName = "�̸� : " + lastName + firstName;
        Debug.Log(displayName);
        // [2-2] ��� : string.Format( ) �޼��带 ���.
        displayName = string.Format("�̸� : {0}{1}", lastName, firstName);        // ) {0} = lastName, {1} = firstName �ڸ���.
        Debug.Log(displayName);
        // [2-3] ��� : ���ڿ� ������ ���.
        displayName = $"�̸� : {lastName}{firstName}";
        Debug.Log(displayName);
    }
}
