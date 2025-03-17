using UnityEngine;


/* [0] 개요 : Category
		- Public Field : 공공(전역)의 사용이 가능함.
        - Private Field : 해당 클래스만 전용으로 사용이 가능함.
        - Field는 Public나 Private 모두 지정이 가능함.
        - Field의 기본 접근제한자는 Private임.
*/
namespace PrivatePublic
{

    public class Category
    {
        // [1] 정의
        public string CategoryName;
    }

}