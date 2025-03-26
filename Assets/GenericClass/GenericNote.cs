using UnityEngine;

/* [0] 개요 : GenericNote
*/

namespace GenericClass
{

    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : T에 string을 지정하여 문자열을 저장하는 속성을 생성. → CupClass의 인스턴스 생성.
                    // ) Cup cup = new Cup(); → NG.
            Cup<string> text = new Cup<string>();       // ) =  public string Content { get; set; }
            text.Content = "문자열";
                    // ) text.Content = 1234; → NG.
            // [1-2] 정의 : T에 int를 지정하여 정수형 숫자를 저장하는 속성 생성.
            Cup<int> number = new Cup<int>();       // ) =  public int Content { get; set; }
            number.Content = 1234;
                    // ) number.Content = "문자열"; → NG.
            // [1-3] 결과
            Debug.Log($"{text.Content} - {number.Content}");

            // [2-1] 정의 : T에 Water(사용자정의 데이터형식)를 지정하면 물을 저장하는 속성을 생성.
            Cup<Water> water = new Cup<Water>();       // ) =  public Water Content { get; set; }
            water.Content = new Water();
            // [2-2] 결과
            Debug.Log(water.Content.ToString());

            // [3-1] 정의
            Cup<Coffee> coffee = new Cup<Coffee>();
            coffee.Content = new Coffee();
            coffee.PrintData(coffee.Content);
            // [3-2] 결과
            Debug.Log(coffee.Content.ToString());
        }
    }
}

// [1] 정의 : 
// [2] 가정 : 
// [3] 결과 :