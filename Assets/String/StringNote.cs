using UnityEngine;


/* [0] 개요 : StringNote
*/


public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : string 변수 선언 + 빈값으로 초기화.
        string str = "";
        str = System.String.Empty;		// ) 빈 값으로 저장. (null은 아님)
        str = " Abc Def Fed Cba ";      // )  문자열 앞,뒤에 공백을 하나씩 주어서 값을 저장함.

        // [2-1] 결과
        Debug.Log(str);
        Debug.Log(str.Length);		// ) 문자열의 길이 구하기.
        Debug.Log(str[5]);		// ) 문자열에서 'D'를 출력.
        Debug.Log(str.ToUpper());       // ) 대문자로 바꾸기.
        Debug.Log(str.ToLower());       // ) 소문자로 바꾸기.
        // [2-2] 결과 : 공백제거.
        Debug.Log(str.Trim());      // ) 앞뒤 양쪽에 있는 공백을 제거.
        Debug.Log(str.TrimStart());      // ) 문자열 앞에 있는 공백 제거.
        Debug.Log(str.TrimEnd());      // ) 문자열 뒤에 있는 공백 제거.
        // [2-3] 결과 : 검색.
        Debug.Log(str.IndexOf('e'));     // ) 문자열 중 'e'가 위치한 인덱스를 가져오기.
        Debug.Log(str.Substring(5, 3));     // ) 5번 인덱스(D)부터 3글자 가져오기. → 문자열 일부 가져오기.
        Debug.Log(str.Substring(5));       // ) 5번 인덱스(D)부터 끝까지 가져오기.
        Debug.Log(str.Remove(5,3));     // ) 5번 인덱스(D)부터 3글자 삭제.
        // [2-4] 결과 : 비교.
        Debug.Log(str[1] == str[15]);       // ) 1번 인덱스와 15번 인덱스가 같은지 비교하기. → false
        Debug.Log("ABC".Equals("Abc"));     // ) 대문자와 소문자 비교하기. → false
        Debug.Log(System.String.Compare("BAC", "Bac"));        // ) 같으면 0, 다르면 1(앞의 것이 클 경우)이나 -1(앞의 것이 작을 경우).
        // [2-4] 결과 : 연결.
        var hi1 = "안녕";
        var hi2 = "하세요";
        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        // [2-5] 결과 : Format의 양식.
        Debug.Log(System.String.Format("{0}{1}", hi1, hi2));
        Debug.Log(System.String.Format("{0:C}", 1000));     // ) C = 통화량(\)을 뜻함.
        Debug.Log(System.String.Format("{0:#,###}", 1000000));     // ) 3자리당 , 찍기.
        // [2-6] 결과 : 분리하기.
        string[] strArray = str.Trim().Split(' ');      // ) Trim을 실행 후, Split을 수행함 → 문자열 전체의 공백을 제거함.
        string strAll = "";
        foreach (var s in strArray)
        {
            // Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }
}
