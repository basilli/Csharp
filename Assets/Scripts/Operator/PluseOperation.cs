using UnityEngine;

// +, -, *, / : ��Ģ ������.
// % : ������(Remainder) ������.
public class PluseOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���ϱ� ����.
        int i = 10;
        int j = 20;
        int k = i + j;
        Debug.Log(k);

        // [2] ���� ����.
        float f = 3.14f;
        float g = 3.14f;
        float e = f - g;
        Debug.Log(e);

        // [3] ���ϱ� ����.
        long a = 100;
        long b = 200;
        long c = a * b;
        Debug.Log(c);

        // [4] ������ ����.
        double l = 1.5;
        double m = 0.5;
        double n = l / m;
        Debug.Log(n);

        // [5] ������ ����. �� ���� 1, �������� 2
        int x = 5;
        int y = 3;
        int z = x % y;
        Debug.Log(z);

    }

}
