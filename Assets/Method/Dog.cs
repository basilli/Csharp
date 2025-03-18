using UnityEngine;


/* [0] 개요 : Dog
*/

namespace Method
{
	public class Dog
	{
		// [1] 정의 : Field 선언.
		public static int point = 10;
		public int weight = 20;
		public void Eat()
		{
			Debug.Log("[1] 밥을 먹는다.");
		}
		public static void drink()
		{
			Debug.Log("[2] 물을 마신다.");
		}
		private void Digest()
		{
			Debug.Log("[3] 소화를 시킨다.");
		}
    }
}
