using UnityEngine;


/* [0] 개요 : ReadOnlyNote
*/

namespace Constructor
{


    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : WithService Class의 인스턴스 생성.
            WithService file = new WithService("[1] 파일 로그");
            file.Run();
            WithService db = new WithService("[2] DB로그");
            db.Run();
        }
    }
}
