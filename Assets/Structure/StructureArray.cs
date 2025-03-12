using Unity.VisualScripting;
using UnityEngine;


/* [0] 개요 : StructureArray
		- 고객의 데이터를 관리하는 구조체를 만드시오.
*/

// [1] 정의
struct UserInfo
{
    public string name;     // ) 고객이름
    public int age;     // ) 고객나이
    // ETC...
}

public class StructureArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-2] 가정 : 구조체 변수 선언
        UserInfo info;
        // [2-3] 가정 : 구조체 초기화
        info.name = "홍길동";
        info.age = 20;
        // [2-4] 가정 : 구조체 사용
        PrintUserInfo(info.name, info.age);
        // [2-5] 가정 : 구조체의 배열 변수 선언 + 배열의 요소수(크기) 생성
        UserInfo[] userInfos = new UserInfo[2];
        // [2-6] 가정 : 구조체 배열 초기화
        userInfos[0].name = "백두산";
        userInfos[0].age = 22;
        userInfos[1].name = "임꺽정";
        userInfos[1].age = 33;

        // [3-1] 결과 : 구조체 배열 사용
        for (int i = 0; i < userInfos.Length; i++)
        {
            PrintUserInfo(userInfos[i].name, userInfos[i].age);
        }
    }
    // [2-1] 가정 : 고객 명단을 출력하는 함수.
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}님의 나이는 {age}살 입니다.");
    }

    // [3-2] 결과
    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}님의 나이는 {userInfo.age}살 입니다.");
    }

}
