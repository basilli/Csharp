using UnityEngine;


/* [0] 개요 : ClassTwo
*/

public class ClassTwo : MonoBehaviour
{
    // [1-1] 정의 : Static 메서드.
    public static void Hi()
    {
        Debug.Log("안녕하세요.");
    }

    // [1-2] 정의 : Instance 메서드.
    public void Hello()
    {
        Debug.Log("또만나요");
    }
}