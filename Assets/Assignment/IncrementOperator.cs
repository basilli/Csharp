using UnityEngine;

// IncrementOperator(����������) : ������ ������ ���� 1 ����.
public class IncrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int num = 100;

        // [2] +1 ������
        ++num; // num += 1; OR num = num + 1;
        Debug.Log("num : " + num);
    }

}
