using UnityEngine;

/* [0] 개요 : GenericPartice
*/
namespace GenericClass
{

    public class GenericPartice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        // [1-1] 정의 : MyList의 GenericClass의 인스턴스 생성. → int 전용.
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }

        // [1-2] 정의 : MyList의 Gen
            MyList<string> names = new MyList<string>(3);
            names[0] = "홍길동";
            names[1] = "백두산";
            names[2] = "장길산";
            foreach (var name in names)
            {
                Debug.Log(name);
            }
        }
    }
}
