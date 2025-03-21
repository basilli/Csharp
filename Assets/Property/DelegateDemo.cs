using UnityEngine;

/* [0] 개요 : DelegateDemo
		- 
		- 
		- 
		- 
		- 
*/

namespace Delegate
{

    public class DelegateDemo : MonoBehaviour
    {
        // [1] 정의 : Delegate 생성 : double형 반환, 매개변수 int → delegate double (대리자 이름) int
        delegate double GetcircleArea(int r);


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {


            // [2] 가정 : Delegate변수 선언 후, 메서스 등록.

            // [3] 결과
        }
    }
}
