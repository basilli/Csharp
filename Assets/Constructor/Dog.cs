using UnityEngine;


/* [0] 개요 : Dog
*/

namespace Constructor
{

	public class Dog
	{
		// [1-1] 정의 : Field 생성.
		private string name;
		// [1-2] 정의 : Constructor 생성. → Field의 초기값 설정. → 매개변수를 받아서 name 필드값을 설정.
		public Dog(string _name)
		{
			name = _name;
		}

		// [2-1] 가정 : name Field를 반환하는 메서드.
		public string Cry()
		{
			return name + "가(이) 멍멍멍";
		}
    }
}
