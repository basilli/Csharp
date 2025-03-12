using UnityEngine;


/* [0] 개요 : EnumAnimal
        - 동물들을 구분하는 열거형 생성.
*/

// [1] 정의
enum Animal     // ) Animal이랑 같은 이름이 다른 스크립트에 있으면 NG가 나옴.
{ 
    Mouse,
    Cow,
    Tiger,
}

public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] 가정 : 열거형 변수 선언 및 초기화.
        Animal animal = Animal.Tiger;

        // [3-1] 결과
        Debug.Log(animal);

        // [3-2] 결과 : 조건문에서 조건식.
        if (animal == Animal.Tiger)
        {
            Debug.Log("호랑이");
        }
    }
}
