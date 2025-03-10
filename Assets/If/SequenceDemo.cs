using UnityEngine;

// ������ : ������ �Ʒ��� ������� ��ɹ��� ����.
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] �������� - �ʱ�ȭ
        int kor = 100;                // ��������
        int eng = 90;                 // ��������
        int total = 0;                  // ����
        double avg = 0.0;           // ���

        // [2] ������ �� ����
        total = kor + eng;          // ����
        avg = total / 2.0;            // ���

        // [3] ���� ���
        Debug.Log($"���� : {total}");
        Debug.Log($"��� : {avg}");

    }
}


/*
    [1] ��� : ���α׷��� �帧(����)�� ���ϴ� ����.
        - ������ : ������ �Ʒ��� ������� ��ɹ��� ����. �� �ƹ��͵� �����ʾƵ� �˾Ƽ� �����.
        - ���ǹ� (if-else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� ����.
        - �ݺ��� (for, while...) : 
        - break�� : �ݺ���(for, while)���� { }�� ���������� ��ɹ�.
        - continue�� : 
 */