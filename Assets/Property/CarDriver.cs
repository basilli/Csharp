using UnityEngine;
using UnityEngine.AI;

/* [0] 개요 : CarDriver
*/

namespace Delegate
{
	public class CarDriver
	{
		// [1] 정의 : 방향 설정 → 모든 객체를 Static로 만듬.
		public static void GoForward()
		{
			Debug.Log("직진");
		}
		public static void GoLeft()
		{
            Debug.Log("좌회전");
        }
        public static void GoRight()
        {
            Debug.Log("우회전");
        }
        public static void GoBack()
        {
            Debug.Log("후진");
        }
    }
}
