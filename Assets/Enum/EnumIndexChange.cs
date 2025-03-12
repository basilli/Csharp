using UnityEngine;


/* [0] 개요 : EnumIndexChange
        - 열거형의 정수값은 순서대로 0으로 시작하여 1씩 증가함. (ex. 0,1,2...)
*/

// [1] 정의 : 동물들을 구분하는 열거형 생성
enum Animale
{ 
    Horse,      // ) 자동적으로 0으로 지정됨.
    Sheep=5,      // ) 인위적으로 5로 지정됨.
    Monkey,      // ) 자동적으로 6으로 지정됨.
    Pig      // ) 자동적으로 7으로 지정됨.
}


public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 결과
        Debug.Log((int)Animale.Monkey);		// ) Monkey에 마우스로 확인하면 정수가 6라는 것을 확인할 수 있음.
    }
}
