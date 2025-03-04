using UnityEngine;

// Type Conversion (형식변환)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] long형 변수 l을 선언하고 long형 변수가 가질 수 있는 가장 큰 값을 저장.
        long l = long.MaxValue;
        Debug.Log("l의 값 : " + l); // 콘솔창에 출력하라.    

        // [2] int형 변수 i를 선언하고 l값을 저장한다.
        int i = (int)l;
        Debug.Log("i의 값 : " + i);
     }
    
}
