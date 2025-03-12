using UnityEngine;

/* [0] 개요 : StructurePractice
		- 중첩 구조체 : 구조체 안에 구조체가 있음.
		- 성적을 관리하는 구조체를 만드시오.
*/

// [1-1] 정의 : 과목의 점수를 관리하는 구조체 선언.
struct Score
{
    public int kor;     // ) 국어점수
    public int eng;     // ) 영어점수
}

// [1-2] 정의 : 학생 정보를 관리하는 구조체 선언.(성적 포함)
struct Student
{
    public int number;      // ) 학생번호
    public string name;     // ) 학생이름
    public Score scores;        // ) 과목 점수([1]에서 정의한 Score 구조체 → 중첩구조)
}

public class StructurePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] 가정 : 학생 구조체 변수 선언 및 요소수 생성.
        Student[] students = new Student[3];
        // [2-2] 가정 : 학생구조체 데이터 초기화.
        students[0].number = 1;
        students[0].name = "홍길동";
        students[0].scores.kor = 100;
        students[0].scores.eng = 90;

        students[1].number = 2;
        students[1].name = "백두산";
        students[1].scores.kor = 90;
        students[1].scores.eng = 80;

        students[2].number = 3;
        students[2].name = "임꺽정";
        students[2].scores.kor = 85;
        students[2].scores.eng = 75;

        // [3] 결과 : 학생 구조체 사용(성적표 출력)
        for (int i = 0; i < students.Length; i++)        // ) for 치고, 탭 2번 누르면 자동으로 나옴.
        {
            Debug.Log($"{students[i].number} - {students[i].name} : 국어 {students[i].scores.kor}점, 영어 {students[i].scores.eng}점");
        }
    }
}
