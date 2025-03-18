using UnityEngine;


/* [0] 개요 : My
*/

namespace Constructor
{

    public class My
    {
        // [1-1] 정의 : Field 선언.
        private string name;        // ) 이름
        int age;        // ) 나이
        // [1-2] 정의 : Constructor(생성자), 이름과 나이 매개변수로 받아 Field 초기화.
        public My(string _name, int _age)
        {
            this.name = _name;
            age = _age;
        }

        // [2] 결과 : 메서드.
        public void PrintMyInfo()
        {
            Debug.Log($"이름 : {this.name}, 나이 : {this.age}");
        }
    }
}
