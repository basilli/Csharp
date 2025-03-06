using UnityEngine;


/*
  [0] 개요 : Switch
        - "1,2,3,4번 답을 선택했습니다." 라고 출력.
        - 1,2,3,4번 외의 값을 선택할 경우 "잘못 선택했습니다." 라고 출력.
        - switch문과 if문 2가지로 구현하시오.
 */
public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int answer = 7;

        // [2] 가정 : if문으로 구현.
        if (answer == 1)
        {
            Debug.Log("1번 답을 선택했습니다. ");
        }
        else if (answer == 2)
        {
            Debug.Log("2번 답을 선택했습니다. ");
        }
        else if (answer == 3)
        {
            Debug.Log("3번 답을 선택했습니다. ");
        }
        else if (answer == 4)
        {
            Debug.Log("4번 답을 선택했습니다. ");
        }
        else
        {
            Debug.Log("잘못 선택했습니다. ");
        }
    }
}

/*
 
// [1] 정의   
int answer = 5;

// [2] 가정 : switch문으로 구현.
switch (answer)
{
    case 1:
        Debug.Log("1번 답을 선택했습니다. ");
        break;
    case 2:
        Debug.Log("2번 답을 선택했습니다. ");
        break;
    case 3:
        Debug.Log("3번 답을 선택했습니다. ");
        break;
    case 4:
        Debug.Log("4번 답을 선택했습니다. ");
        break;
    default:
        Debug.Log("잘못 선택했습니다. ");
        break;
}

*/
