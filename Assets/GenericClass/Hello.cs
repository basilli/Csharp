using UnityEngine;

/* [0] 개요 : Hello
*/

namespace GenericClass
{
// [1-1] 정의 : GenericClass 만들기
    public class Hello<T>
	{
    // [1-2] 정의 : Field
        private T _message;

    // [1-3] 정의 : Constructor
        public Hello()
        {
            this._message = default(T);
        }
        public Hello(T message)
        {
            _message = message;
        }

    // [1-4] 정의 : Method
        public void Say(T message)
        {
            Debug.Log($"{message}");
        }
        public T GetMessage() => this._message;
    }
}