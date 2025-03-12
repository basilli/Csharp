using UnityEngine;


/* [0] 개요 : ClassMember
*/

public class ClassMember
{
	// [1-1] 정의 : static(정적) 메서드
	public static void StaticMethod()
	{
		Debug.Log("static(정적) 메서드");
	}

	// [1-2] 정의 : instance 메서드
	public void InstanceMethod()
	{
        Debug.Log("Instance 메서드");
    }
}
