using UnityEngine;

public class IntToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] x�� int�� ���� x�� �����ϰ� 255�� �ʱ�ȭ.
        int x = 255;
        // [2] byte�� ���� y�� �����ϰ� x�� ������ �ʱ�ȭ.
            // byte�� ������� : 0~255.
        byte y = (byte)x;

        Debug.Log(x + " �� " + y);

    }
}
