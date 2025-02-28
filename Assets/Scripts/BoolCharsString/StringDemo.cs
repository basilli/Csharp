using UnityEngine;

// string(문자열) : 문자열 데이터 형식
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 문자열변수 선언하고 초기화
        string name = "홍길동";

        // [2] 사용하기
        Debug.Log("안녕하세요. " + name + " 입니다");
        Debug.Log("Hello. my name is " + name);
        Debug.Log("こんにちは。私の名前は " + name + "です。");
        Debug.Log("你好，我叫 " + name);
        Debug.Log("Hola, mi nombre es" + name);

        // [3] Unity에서 볼 때는 안녕하세요만 나오지만, 클릭해서 볼 경우 문장 전체를 볼 수 있음.
        string multiLine = @"
                             안녕하세요.
                             반갑습니다.";

        Debug.Log(multiLine);
    }

}
