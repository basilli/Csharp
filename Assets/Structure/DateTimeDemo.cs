using UnityEngine;


/* [0] 개요 : DateTimeDemo
        - 내장형 구조체 (DateTime) 사용.
		- 날짜 및 시간 정보를 저장하고 조작할 수 있는 구조체.
		- 날짜와 시간을 다룰 때 년, 월, 일, 시, 분, 초 등의 정보를 포함함.
		- 날짜를 비교하거나, 더하거나, 형식을 바꿔서 출력하는 기능이 있음.
		- DateTime.Now (현재로컬시간), DateTime.UtcNow (현재 UTC 시간), DateTime.Today(오늘 날짜) 등 같은 유용한 속성이 있음.
*/
public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 및 결과 : 현재시간을 출력.
        Debug.Log($"현재시간 : {System.DateTime.Now}");

        // [1-2] 정의 및 결과 : 현재 년, 월, 일, 시, 분, 초를 출력.
        Debug.Log(System.DateTime.Now.Year);
        Debug.Log(System.DateTime.Now.Month);
        Debug.Log(System.DateTime.Now.Day);
        Debug.Log(System.DateTime.Now.Hour);
        Debug.Log(System.DateTime.Now.Minute);
        Debug.Log(System.DateTime.Now.Second);

        // [2] 가정 : DateTime 구조체 변수를 선언해서 사용.
        System.DateTime now = System.DateTime.Now;

        // [3] 결과
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());
    }
}
