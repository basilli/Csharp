using UnityEngine;


/* [0] 개요 :Car
*/

namespace Constructor
{
    public class Car
    {
        // [1-1] 정의 : Field.
        private string color;
        // [1-2] 정의 : 기본 Constructor.
        public Car()
        {
            color = "하얀";
            Debug.Log($"{color}색 자동차를 만듭니다.");
        }
        // [1-3] 정의 : 매개변수가 있는 Constructor.
        public Car(string _color)
        {
            this.color = _color;
            Debug.Log($"{color}색 자동차를 만듭니다.");
        }
        // [1-4] 정의 : 메서드. → 사용.
        public void Run()
        {
            Debug.Log($"{color}색 자동차가 달립니다.");
        }
        // [1-5] 정의 : Destructor.
        ~Car()
        {
            Debug.Log($"{color}색 자동차를 폐차합니다..");
        }
    }
}
