using UnityEngine;

// [0] ���� : �ΰ��� ���� ���̸� ���� ������ ���Ͻÿ�.
public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int first = -3;
        int second = -8;
        int diff = 0;   // �� ���� ���̰�.

        // [2] ���� : ū �� �Ǻ���
        if (first >= second)
        {
            diff = first - second;
        }
        else
        {
            diff = second - first;
        }

        // [3] ���
        Debug.Log($"diff : {diff}");
    }

}
