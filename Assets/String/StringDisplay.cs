using UnityEngine;


/* [0] 개요 : StringDisplay
		- 문자열 묶는 방법(문자열 꾸미기)
            - string 더하기(+) 연산자 이용.
            - string.Format( ) 메서드를 사용.
            - 문자열 보간법 사용.
*/

public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";

        // [2-1] 결과 : string 더하기(+) 연산자 이용.
        displayName = "이름 : " + lastName + firstName;
        Debug.Log(displayName);
        // [2-2] 결과 : string.Format( ) 메서드를 사용.
        displayName = string.Format("이름 : {0}{1}", lastName, firstName);        // ) {0} = lastName, {1} = firstName 자리임.
        Debug.Log(displayName);
        // [2-3] 결과 : 문자열 보간법 사용.
        displayName = $"이름 : {lastName}{firstName}";
        Debug.Log(displayName);
    }
}
