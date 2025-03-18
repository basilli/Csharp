using UnityEngine;


/* [0] 개요 : ConstructorMethod
*/

namespace Constructor
{


    public class ConstructorMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : Student Class의 인스턴스 생성. → Constructor(생성자) 호출.
            Student student = new Student();
        }
    }
}
