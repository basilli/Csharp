using UnityEngine;


/* [0] 개요 : EnumSwitch
		- 열거형은 Switch문과 함께 많이 사용됨.
		- 한글 동물 이름을 출력하시오.
*/

// [1] 정의
enum Animalw
{ 
    Chicken,
    Dog,
    Pig
}


public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-2] 가정 : 열거형 변수 선언 및 초기화
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);

    }
    // [2-1] 가정 : 매개변수로 열거형 변수를 받아 한글 이름을 출력.
    void PrintAnimal(Animalw animal)
    {
        // [3] 결과
        switch (animal)
        {
            case Animalw.Chicken:
                Debug.Log("딹");
                break;
            case Animalw.Dog:
                Debug.Log("깨");
                break;
            case Animalw.Pig:
                Debug.Log("뙈지");
                break;
        }
    }
}
