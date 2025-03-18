using UnityEngine;



/* [0] 개요 : ConstrictorParameter
*/

namespace Constructor
{

    public class ConstrictorParameter : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 결과 : My클래스의 
            My my = new My("홍길동", 21);
            my.PrintMyInfo();
        }
    }
}
