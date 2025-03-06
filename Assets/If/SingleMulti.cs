using UnityEngine;
using UnityEngine.Rendering;

// 실행문 : 단문(1개), 복문(2개 이상)
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [0] 만약 조건식이 참이면 { } 안에 있는 실행문을 실행하라.
        /*
         if(조건식)
         {
            //실행문1
            //실행문2
            //...
         }
         */

        // [1] 단문 : 실행문이 1개일 때.
        if (1 == 1) ;
        {
            Debug.Log("단문 1");
        }

        // [1-2] if문에 { }이 생략이 되면 바로 아래있는 1줄만 실행.
        if (1 == 1) ;
        Debug.Log("단문 2");

        // [1-3] if문을 한줄로 압축.
        if (1 == 1) Debug.Log("단문 3");

        // [2] 복문 : 실행문이 2개 이상일 때.
        if (1 == 1)
        {
         Debug.Log("복문 1");
         Debug.Log("복문 2");
        }

    }
}

