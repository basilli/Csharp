using UnityEngine;

/* [0] 개요 : Child
*/

namespace Inheritance06
{
    public class Child : Parent
    {
        // [1-1] 정의 : Child

        // [1-2] 정의 : Constructor
        public Child() : this("홍길동")
        { 
        
        }

        public Child(string message) : base(message)
        { 
        
        }

        public void SayName()
        {
            Debug.Log(base.Word);
        }
    }
}

