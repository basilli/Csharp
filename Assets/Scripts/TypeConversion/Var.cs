using UnityEngine;

// var : 암시적으로 형식화 된 로컬 변수
// var은 선언할 때, 데이터 초기화를 반드시 한다.
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "홍길동";   // name을 str형 이라고 함. → 변수에 입력되는 값("홍길동")을 보고 name이라는 변수를 string형식으로 결정함.
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 8.0;       // version을 double형이라고 함. → 변수에 입력되는 값(8.0)을 보고 version이라는 변수를 double형식으로 결정함.
        Debug.Log(version);
        Debug.Log(version.GetType());

        var car = 1;              // car을 int형이라고 함. → 변수에 입력되는 값(car)을 보고 car이라는 변수를 int형식으로 결정함.
        Debug.Log(car);
        Debug.Log(car.GetType());
    }
}
