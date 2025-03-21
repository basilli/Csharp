using UnityEngine;

/* [0] 개요 : Child
*/

namespace Inheritance
{
    // [1] 정의 : 자식 클래스
    public class Child : Parent		// ) Parent가 부모Class라고 지정하여 선언함.
	{

		// [2] 가정
		public void Bar()
		{
			Debug.Log("자식Class의 Member 호출");
		}
    }
}
