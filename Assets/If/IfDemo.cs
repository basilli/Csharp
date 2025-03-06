using UnityEngine;

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // [1] 정의 : 만약 x가 10이면 x는 10입니다. 출력.
        int x = 10;
             /*
             if (x가 10이면)
             { 
             x는 10입니다. 출력.
             }
             */
        // [1-2] 선언
        if (x == 10)
        {
            Debug.Log("x는 10입니다.");
        }



        // [2] 정의 : 만약 x가 20이 아니면 x는 20이 아닙니다. 출력.
              /*
              if (x가 20이 아니면)
              { 
              x는 20이 아닙니다. 출력.
               }
               */
        // [2-1] 선언
        if (x != 20)
        {
            Debug.Log("x는 20이 아닙니다.");
        }
    }
}
