using UnityEngine;

/* [0] 개요 : FieldHiddenDemo
*/

namespace Inheritance11
{
    public class FieldHiddenDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : SubClass의 인스턴스 생성.
            SubClass sub = new SubClass();
            sub.SetWord("Field 숨기기 및 ChildClass에게만 Member 상속");

            // [2] 결과 
            Debug.Log(sub.GetWord());
        }
    }
}
