using UnityEngine;

// DecrementOperator(���� ������) : ������ ������ ���� 1 ����.
public class DecrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int num = -100;

        // [2] -1 ���ҽ�
        --num; // num -= 1; OR num = num - 1;
        Debug.Log("num : " + num);
    }
    

}
