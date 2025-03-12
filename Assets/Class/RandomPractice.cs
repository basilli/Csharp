using UnityEngine;


/* [0] 개요 : RandomPractice
		- [Q]
            - 로또 번호 생성기를 만드시오.
            - 1번~45번 사이의 랜덤번호 중에서 서로 다른 6개의 당첨번호를 정하시오.

		- [output]
            - 조건에 맞는 번호6개를 출력하시오.
*/

public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Random Class 객체 생성.
        System.Random rand = new System.Random();
        // [1-1] 정의 : 배열 변수 선언 및 요소수 생성.
        int[] numbers = new int[6];
        // [1-2] 정의 : 랜덤값을 저장하는 변수.
        int number = 0;
        // [1-3] 정의 : 중복검사를 실행하였을 때 중복이면 true, 아닐경우 false.
        bool flag = false;

        // [2-1] 가정
        for (int i = 0; i < 6; i++)
        {
            // [2-1-1]
            number = rand.Next(1, 46);      // ) 1~46까지의 랜덤값을 받아옴.
            flag = false;       // ) 중복체크. number와 먼저 뽑힌 로또번호와 비교를 하여 검사를 실행함.
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;        // ) false일 경우 무한루프에 걸리기때문에, 얘는 무조건 true가 되어야 함.
                    }
                }
            }
            // [2-1-2]
            if (flag == false)      // ) 중복이 아닐 경우.
            {
                numbers[i] = number;
            }
            else      // ) 중복일 경우, 다시 계산을 해야하기 때문에 인덱스를 조정해야 함.
            {
                i--;
            }
        }
        // [3] 결과 : 로또번호 출력.
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}

/*
          number[0] : 중복검사 X.
          number[1] : [0]
          number[2] : [0], [1]
          number[3] : [0], [1], [2]
          number[4] : [0], [1], [2], [3]
          number[5] : [0], [1], [2], [3], [4]
          number[6] : [0], [1], [2], [3], [4], [5]

*/