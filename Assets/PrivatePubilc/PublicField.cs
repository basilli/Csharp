using UnityEngine;


/* [0] 개요 : PublicField
*/

namespace PrivatePublic
{

    public class PublicField : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : Category 클래스의 인스턴스 생성.
            Category book = new Category();

            // [2] 가정 : 다른 클래스의 필드에 데이터 저장 : 개체이름, 멤버 이름.
            book.CategoryName = "책";

            // [3] 결과
            Debug.Log(book);
        }
    }
}
