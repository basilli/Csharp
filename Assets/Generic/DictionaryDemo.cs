using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* [0] 개요 : DictionaryDemo
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
*/


public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : Dictionary 클래스의 인스턴스 생성.
        IDictionary<string, string> data = new Dictionary<string, string>();
        // [1-2] 가정 : Dictionary 데이터 입력.
        data.Add("시", "서울특별시");
        data.Add("구", "강동구");
        // [1-3] 결과 : Dictionary 데이터 출력.
        data.Remove("시");

        // [2-1] 가정 : Dictionary 데이터 입력. → indexer사용.
        data["동"] = "천호동";
        // [2-2] 결과 : Dictionary 데이터 출력. → 키값은 중복이 불가하며, 같은 키값으로 추가가 안됨.
        try
        {
            data["구"] = "강남구";     // ) 이걸로 할 경우, OK.
            data.Add("구", "강남구");       // ) 이걸로 할 경우, N.G 발생.
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
        // [2-3] 결과
        foreach (KeyValuePair<string, string> item in data)
        {
            Debug.Log($"{item.Key} - {item.Value}");
        }

        // [3] 결과
        Debug.Log(data["구"]);
    }
}
