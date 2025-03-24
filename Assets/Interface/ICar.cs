using UnityEngine;

/* [0] 개요 : ICar 
*/

namespace Interface
{
    // [1] 정의 : ICar Interface 선언.
    public interface ICar
    {
     void Go();		// ) Method 정의, {} 구현부분 생략.
    }

    // [2] 가정 : ICar Interface 상속.
    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("상속한 인터페이스의 정의된 모든 멤버를 반드시 구현해야한다.");
        }
    }
}