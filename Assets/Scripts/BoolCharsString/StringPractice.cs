using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ����
        string num = "3";
        // ���
        const int message = "��(��) Ȧ���Դϴ�."
        Debug.Log($"{num} - {message}");
    }

}



/*
    [Q] 
        3, Ȧ���� ���� �����ϰ� �����Ѵ�.
        ���ڿ� �������� �̿��ؼ� ����� ������ ����ϱ�.

    [Output]
        3��(��) Ȧ���Դϴ�.
*/
