using UnityEngine;


// [0] ���� : SwitchStatement
public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        Debug.Log(" ���� ������ �����? (����, �帲, ��, ��) ");
        string weather = "��";

        // [2] ����
        switch (weather)
        {
            case "����":
                Debug.Log(" ���� ������ �����ϴ�. ");
                break;
            case "�帲":
                Debug.Log(" ���� ������ �帳�ϴ�. ");
                break;
            case "��":
                Debug.Log(" ���� ������ �� �����ϴ�. ");
                break;
            default:    // ����, �帲, ��� �����ʾ��� ���, ������ ������ ǥ���.
                Debug.Log(" ���� ������ ���� �����ϴ�. ");
                break;
        }
    }
}
