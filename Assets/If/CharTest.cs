using UnityEngine;

public class CharTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        char c = 'a';

        // [2] ���� �� ��� : �빮�� �Ǻ���.
        if (c >= 'a' && c <= 'z')
        {
            Debug.Log($"{c}�� �빮�� �Դϴ�.");
        }
        else
        {
            Debug.Log($"{c}�� �ҹ��� �Դϴ�.");
        }
    }
}
