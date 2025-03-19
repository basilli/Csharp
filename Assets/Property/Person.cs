using UnityEngine;

/* [0] 개요 : PropertyFull Person
*/

namespace Property
{
	public class Person
	{
		// [1-1] 정의 : Field, 멤버변수
		private string name;
        // [1-4] 정의 : Public한 Property를 이용하여 Private한 Field(name)에 접근.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // [1-2] 정의 : Public한 메서드를 이용하여 Private한 Field(name)에 접근.
        public void SetName(string _name)
        {
            name = _name;
        }
        // [1-3] 정의
        public string GetName()
        {
            return name;
        }
    }
}
