using UnityEngine;


/* [0] 개요 : StaticAndInstance
		- 정적(Static, shared) 멤버와 Instance 멤버
*/

// [1-1] 정의 : 클래스 선언
public class ShareAndInstance
{
    // [1-2] 정의 : Static 멤버 → 정의 할 때, public 뒤에 static를 추가하면 됨.
    public static void StaticMember() => Debug.Log("[1] Static Member");
    // [1-3] 정의 : Instance 멤버
    public void InstanceMember() => Debug.Log("[2] Instance Member");
}

public class StaticAndInstance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 가정 : StaticAndInstance 클래스 사용.
        // [2-1] 가정 : Static 멤버 사용. → ' 클래스이름.맴버이름( ); ' 으로 호출함.
        ShareAndInstance.StaticMember();
        // [2-2] 가정 : Instance 멤버 사용. → ' 개체이름.맴버이름( ); ' 으로 호출함.
        ShareAndInstance obj = new ShareAndInstance();
        obj.InstanceMember();
    }
}
