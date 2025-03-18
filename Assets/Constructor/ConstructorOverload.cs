using UnityEngine;


/* [0] 개요 : ConstructorOverload
*/

namespace Constructor
{


    public class ConstructorOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 결과 : ConstructorLog Class 인스턴스 생성.
            ConstructorLog log1 = new ConstructorLog();
            ConstructorLog log2 = new ConstructorLog("홍길동");
            ConstructorLog log3 = new ConstructorLog("백두산");
        }
    }
}
