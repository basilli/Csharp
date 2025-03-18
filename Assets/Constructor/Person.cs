using UnityEngine;


/* [0] 개요 : Person
*/

namespace Constructor
{
    public class Person
    {
        // [1-1] 정의 : Field 생성.
        private string name;
        // [1-2] 정의 : Constructor(매개변수 X)
        public Person()
        {
            name = "홍길동";
        }
        // [1-3] 정의 : 매개변수로 이름을 입력.
        public Person(string _name)
        {
            name = _name;
        }
        // [1-4] 정의 : 메서드(Private한 이름을 Public한 메서드로 외부에서 사용가능하도록 함.)
        public string GetName()
        {
            return name;
        }
    }
}
