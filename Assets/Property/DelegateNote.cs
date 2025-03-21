using UnityEngine;

/* [0] 개요 : DelegateNote
*/

namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        // [1-1] 정의 : 대리자 선언.(반환값 X, 매개변수 X)
        delegate void GoHome();
        // [1-2] 정의 : Delegate 변수 선언 후, 메서드 등록.
        GoHome go;
        // [1-3] 정의 : Delegate 변수 선언.
        delegate void Say();
        // [1-4] 정의 : Delegate 변수 선언.
        Say sayC;
        // [1-5] 정의 : Action 형식을 통하여 대리자 객체 생성. → [1-1,2]를 축약함.
        System.Action driver;       // ) Action이나 Func를 사용함.

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [2-1] 가정 : 직접 운전(직진 → 우회전 → 직진 → 좌회전)
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            Debug.Log("====================================");

            // [3-1] 결과 : 대리자 변수에 메서드 등록.
            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);      // ) 메서드 등록.
            go -= new GoHome(CarDriver.GoForward);      // ) 메서드 취소.
            go();

            Debug.Log("====================================");

            // [4-3] 결과 : 대리자 변수 선언 및 메서드 등록.
            Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();
            // [4-4] 결과 : 대리자 변수 선언 및 메서드 등록.
            Insa insa = new Insa();
            Say sayB = insa.Bye;
            sayB += insa.Bye;
            sayB += Hi;
            sayB.Invoke();

            Debug.Log("====================================");

            // [4-5] 결과 : 메서드 등록없이 호출 → sayC = Null
            sayC?.Invoke();
            Debug.Log("====================================");
            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += () => Debug.Log("후진");
            driver += delegate () { Debug.Log("주차"); };
            driver?.Invoke();

            driver += CarDriver.GoForward;
            driver += CarDriver.GoForward;

            /* [A] = sayC?.Invoke(); 와 같음.
            if (sayC != null)
            {
                sayC.Invoke();
            }
            */
        }
        // [4-1] 정의 : 대리자 변수 선언.
        void Hello() => Debug.Log("Hola");
        void Hi()
        {
        }
    }
}