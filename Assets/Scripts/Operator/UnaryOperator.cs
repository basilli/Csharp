using UnityEngine;

// UnaryOperator(���׿�����) : +, -
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] int�� ���� value �����ϰ� 0���� �ʱ�ȭ.
        int value = 0;

        // [2]
        value = 8;  // value ������ 8�̶� ���� ���� �� 8.
        value = +value;
        Debug.Log(value); // 8

        // [3]
        value = -8;  // value ������ -8�̶� ���� ���� �� -8.
        value = +value;
        Debug.Log(value); // -8

        // [4]
        value = 8;  // value ������ 8�̶� ���� ���� �� 8.
        value = -value;
        Debug.Log(value); // -8

        // [5]
        value = -8;  // value ������ -8�̶� ���� ���� �� -8.
        value = -value;
        Debug.Log(value); // 8
    }
}
