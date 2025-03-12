using UnityEngine;


/* [0] 개요 : EnumIndex
		- 열거형 값을 정수형이나 문자열로 사용이 가능.
*/

// [1] 정의
enum Animals
{
    Rabbit,
    Dragon,
    sanke,
}
public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 가정 : 열거형 변수 선언 및 초기화.
        Animals animals = Animals.Dragon;
        int num = (int)animals;
        string str = animals.ToString();

        // [3] 결과
        Debug.Log($"Animals.Dragon : {num}, {str}");
    }
}
