using UnityEngine;


/* [0] ���� : ClassMember
		- Debug �巡�� �� ������ ���콺 �� ���Ƿ� �̵�
*/

public class ClassMember
{
	// [1-1] ���� : static(����) �޼���
	public static void StaticMethod()
	{
		Debug.Log("static(����) �޼���");
	}

	// [1-2] ���� : instance �޼���
	public void InstanceMethod()
	{
        Debug.Log("Instance �޼���");
    }
}
