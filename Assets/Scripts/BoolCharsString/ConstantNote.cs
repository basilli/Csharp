using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ����
        string name = "ȫ�浿";
        name = "�̼���";   // �����̹Ƿ� ���� O

        // ���
        const int AGE = 20;   // AGE�� 20��� ������
        // AGE = 21;   // ����̹Ƿ� ���� X �� �����ϸ� ������ �߻���

        // ����, ��� ���
        Debug.Log($"{name} - {AGE}");

    }

}
