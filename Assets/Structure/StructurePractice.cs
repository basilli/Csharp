using UnityEngine;

/* [0] ���� : StructurePractice
		- ��ø ����ü : ����ü �ȿ� ����ü�� ����.
		- ������ �����ϴ� ����ü�� ����ÿ�.
*/

// [1-1] ���� : ������ ������ �����ϴ� ����ü ����.
struct Score
{
    public int kor;     // ) ��������
    public int eng;     // ) ��������
}

// [1-2] ���� : �л� ������ �����ϴ� ����ü ����.(���� ����)
struct Student
{
    public int number;      // ) �л���ȣ
    public string name;     // ) �л��̸�
    public Score scores;        // ) ���� ����([1]���� ������ Score ����ü �� ��ø����)
}

public class StructurePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] ���� : �л� ����ü ���� ���� �� ��Ҽ� ����.
        Student[] students = new Student[3];
        // [2-2] ���� : �л�����ü ������ �ʱ�ȭ.
        students[0].number = 1;
        students[0].name = "ȫ�浿";
        students[0].scores.kor = 100;
        students[0].scores.eng = 90;

        students[1].number = 2;
        students[1].name = "��λ�";
        students[1].scores.kor = 90;
        students[1].scores.eng = 80;

        students[2].number = 3;
        students[2].name = "�Ӳ���";
        students[2].scores.kor = 85;
        students[2].scores.eng = 75;

        // [3] ��� : �л� ����ü ���(����ǥ ���)
        for (int i = 0; i < students.Length; i++)        // ) for ġ��, �� 2�� ������ �ڵ����� ����.
        {
            Debug.Log($"{students[i].number} - {students[i].name} : ���� {students[i].scores.kor}��, ���� {students[i].scores.eng}��");
        }
    }
}
