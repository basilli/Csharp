using UnityEngine;

/* [0] 개요 : BaseKeyword
*/

namespace Inheritance05
{
    public class BaseKeyword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 결과
            new My().Run();
            new My("아반테").Run();
            new Your().Run();
        }
    }
}
