using UnityEngine;


/* [0] 개요 : ArrayForEach
		- foreach : 배열에 저장된 여러개의 값을 순서대로 가져와서 사용.
        - 배열의 데이터를 처음부터 끝까지 가져오고, 더 이상 가져올 수 없을 경우 반복문을 종료함.
        - 형태
            foreach (배열의 데이터타입 변수이름 in 배열변수 이름)
            {
                // 반복실행문
            }

		- 배열 요소들의 값을 모두 가져와서 총합을 구하는 프로그램을 만드시오.
*/
public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        float[] arr = { 10.5f, 20.1f, 30.3f };
        float sum = 0f;

        // [2] 가정
        /*
                // [2-1] for 문
                for (int i = 0; i < 3; i++)
                {
                    sum = sum + arr[i];     // ) 배열은 항상 반복문과 같이 쓰임.
                }
        */
        // [2-2] foreach 문
        foreach (float f in arr)        // ) arr에 있는 데이터 중 가장 앞에 있는걸 f에 저장함.
        {
            sum = sum + f;      // ) 반복실행문
        }

        // [3] 결과
        Debug.Log($"총 합은 {sum}입니다.");
    }
}
