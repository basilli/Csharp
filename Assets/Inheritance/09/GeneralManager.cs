using UnityEngine;

/* [0] 개요 : GeneralManager
        - AbstractClass : 자신을 상속받는 ChildClass에게 강제로 지정한 기능(Method)를 추가하도록 함.
        - Abstract Method : 지정한 기능(Method), 
        - 형태
            public abstract void (추상 Method 이름)();
*/
namespace Inheritance09
{
    // [1-1] 정의 : AbstractClass 선언. 
    public abstract class GeneralManager
    {
        // [1-2] 정의 : Abstract Method.(Method) 구현 부분( = 코드블록{}, 본문)을 생략함.
        public abstract void SayTalk();
    }
        // [1-3] 정의 : AbstractClass(GeneralManager)을 상속받는 ChildClass.
        public class Person : GeneralManager
        {
            public override void SayTalk()      // ) 상속받은 AbstractMethed 구현 부분. → public override void (추상 Method 이름)() 
            {
                Debug.Log("상속받는 AbstructMethod를 구현한다.");
            }
        }
    }
