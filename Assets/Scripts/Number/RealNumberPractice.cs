using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float f = 3.14F;
        double d = 3.14D;
        decimal m = 3.14M;

        Debug.Log("float : " + f);
        Debug.Log("double : " + d);
        Debug.Log("decimal : " + m);
    }

}

/*
 [Q]
    실수형 값 float 3.14, double 3.14, decimal 3.14 값 출력하기

 [Output]
    float : 3.14
    double : 3.14
    decimal : 3.14
*/

/*
 [1] 내가 적었는데 NG남 → 위와 뭐가 틀린지 비교할 것
        double f = 3.14;
        float f = 3.14;
        decimal f = 3.14;

        Debug.Log("double");
        Debug.Log("float");
        Debug.Log("decimal");
*/

