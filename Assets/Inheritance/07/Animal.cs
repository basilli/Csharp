using UnityEngine;

/* [0] 개요 : Animal
*/

namespace Inheritance07
{
    public class Animal
    {
        // [1-1] 정의 : ParentClass
        public void Eat() => Debug.Log("밥을 먹어요.");

        // [1-2] 정의 : ChildClass → Animal을 Prarent로 지정.
        public sealed class Cat : Animal        // ) 'sealed'를 이용하여 CatClass를 봉인(sealed)Class로 지정 → 최종Class가 되어 상속이 불가능하며 나를 Parent로 지정하지 못하도록 막음.
        { 
        
        }

        // [1-3] 정의 : ChildClass → Cat을 Parent로 지정.

        /* [A]
        public class MyCat : Cat
        { 
        
        }
                // ) sealed가 붙은 Class는 Parent로 지정이 불가능함.
        */
    }
}
