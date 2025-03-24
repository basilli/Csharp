using UnityEngine;
using System.Collections;

/* [0] 개요 : CarWorld IStandard
*/

// [1-1] 정의 : Namespace 선언. → 뒤에 Test를 붙여서 Class의 이름 충돌 방지, 성격과 기능이 비슷한 Class를 묶음.
namespace InterfaceTest
{
    // [1-2] 정의 : Interface 선언. → 공통기능을 모아서 Class를 설계 및 다중 상속 가능.
    public interface IStandard
	{
        void Run();     // ) 공통기능 : Method 지정 및 상속받은 ChildClass에서 구현하도록 강제함.
	}

    // [1-3] 정의 : Class 인스턴스를 찍어낼 수 있게 만드는 설계도.
    public class Car : IStandard
    {
        // [1-3-1] 정의 : Field (멤버변수, 전역변수, Private가 기본.)
        #region Field
        private string name;        // ) 전역변수
        private string[] names;     // ) 배열
        private readonly int _Length;        // ) 읽기전용 필드.
        #endregion

        // [1-3-2] 정의 : Construct (Field 초기화)
        #region Construct
        public Car()
        {
            this.name = "좋은 차";
        }
        // [1-3-2] 정의 : 배열
        public Car(string _name)
        {
            this.name = _name;
        }
        // [1-3-2] 정의 : 읽기전용 필드.
        public Car(int length)
        {
            this.name = "좋은 차";
            _Length = length;        // ) 읽기전용 Field는 Construct 안에서 초기화 가능.
            names = new string[_Length];
        }
        #endregion

        // [1-4] 정의 : Member Method
        #region Method
        public void Run()
        {
            Debug.Log($"{name}가 달립니다.");
        }
        #endregion

        // [1-5] 정의 : 속성 → Public이 기본이며, Private Field를 외부에 공개함.
        #region Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return _Length; }
        }
        #endregion

        // [1-6] 정의 : Destructor(소멸자) → 객체가 소멸될 때 호출.
        #region Destructor
        ~Car()
        {
            Debug.Log($"{name}가 폐차됨.");
        }
        #endregion

        // [1-7] 정의 : Indexer(인덱서) → 반복기
        #region Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        // [1-8] 정의 : 대리자
        #region Delegate
        public delegate void EventHandler();
        // [1-8-1] 정의 : Event
        public event EventHandler Click;
        public void OnClick()
        {
            if (Click != null)
            {
                Click.Invoke();
            }
        }


        #endregion
    }
}


// [1] 정의 : 
// [2] 가정 : 
// [3] 결과 : 