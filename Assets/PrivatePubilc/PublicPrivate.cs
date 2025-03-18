using UnityEngine;


/* [0] 개요 : PublicPrivate
*/

namespace PrivatePublic
{

	public class PublicPrivate
	{
		// [1-1] 정의 : Static Field
		public static string name = "트럭";
        // [1-2] 정의 : Field
        private int age;
        // [1-3] 정의 : Static 메서드(이름을 반환하는 함수.)
        public static string GetName()
        {
            return name;
        }
        // [1-4] 정의 : Private Field를 Public 메서드로 접근.
        public void SetAge(int nai)
        {
            age = nai;
        }
        // [1-5] 정의
        public int GetAge()     // ) public static int GetAge() → NG.
        {
            return age;
        }
    }
}
