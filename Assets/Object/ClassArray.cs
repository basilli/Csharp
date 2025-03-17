using UnityEngine;


/* [0] 개요 : ClassArray
		- 인스턴스 배열 만들기.
		- 특정 클래스 형식의 배열을 선언. → 배열요소들의 각각 인스턴스를 생성 한 후, 사용.
*/

// [1-1] 정의 및 결과
public class CategoryClass
{
    public void Print(int i) => Debug.Log($"카테고리 {i}");
}

public class ClassArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-2] 정의 : CategoryClass 클래스 정의 선언.
        CategoryClass[] categories = new CategoryClass[3];

        // [2] 가정 : 배열 요소들의 각각 인스턴스를 생성.
        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        // [3] 결과 : 인스턴스 사용.
        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
