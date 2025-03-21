using UnityEngine;

/* [0] 개요 : Car
*/

namespace Inheritance05
{
	public class Car
	{
        // [1-1] 정의 : ParentClass, Field
        private string name;

        // [1-2] 정의 : Constructor를 만들어 매개변수를 통하여 Name 초기화.
        public Car(string _name)
        {
            this.name = _name;
        }

        // [1-3] 정의 : 메서드
        public void Run() => Debug.Log($"{name}가 달린다.");
    }
}
