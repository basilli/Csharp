using UnityEngine;
using PrivatePublic;


/* [0] 개요 : Person
		- 필드의 종류.
*/

namespace PrivatePublic
{


	public class Person
	{
		// [1-1] 정의 : 변수 형식 필드.
		private string name = "홍길동";
		// [1-2] 정의 : 상수 형식 필드.
		private const int AGE = 21;
		// [1-3] 정의 : 읽기전용 형식 필드.
		private readonly string NickName = "도깨비";
		// [1-4] 정의 : 배열 형식 필드.
		private string[] address = { "서울", "수원", "인천" };
		// [1-5] 정의 : Object 형식 필드.
		private object obj = System.DateTime.Now.ToShortTimeString();

		// [2] 결과 : Public 메서드.
		public void ShowProfile()
		{
			Debug.Log($"이름 : {name}, 나이 : {AGE}, 별명 : {NickName}");
		}
    }
}
