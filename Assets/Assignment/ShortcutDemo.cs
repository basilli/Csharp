using UnityEngine;

// +=, -=, *=, /=, &= : ������, ��Ģ����+����
public class ShortcutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int a = 3;
        int b = 5;

        // [2] b������ a������ ���� �����϶�.
        b += a; // b = b + a; �� ����.
        Debug.Log(b);

        // [3] b������ a������ ���� �����϶�.
        b -= a; // b = b - a;�� ����
        Debug.Log(b);

    }
}
