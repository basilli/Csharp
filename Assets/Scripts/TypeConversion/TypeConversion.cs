using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] double형 실수형 변수 d를 선언하고 12.34로 초기화.
        double d = 12.34;
        // [2] int형 정수형 변수 i를 선언하고 1234로 초기화.
        int i = 1234;
        // [3] double > int : 묵시적(암묵적, 암시적) 형식 변환.
        d = i;
        Debug.Log("암묵적 형식변환 : " + d);

        d = 12.34;
        i = 1234;
        // [4] double < int : 명시적인 형식 변환이 필요.
        i = (int)d; // ( ) : 캐스트 연산자
        Debug.Log("명시적인 형식 변환 : " + i);

        d = 12.34;
        i = 1234;
        // [5] 다른 형식간의 변환.
        string s = ""; // string 변수 s를 선언하고 ""(빈값)으로 초기화 → 아무 값도 안넣음.
        s = d.ToString();
        s = i.ToString();
        Debug.Log("다른 형식 변환 : " + s);
    }
}
