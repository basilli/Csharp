using UnityEngine;

// �� ���� �Է¹޾� �� �߿��� ū ���� ���.
public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int first = 5;
        int second = 8;

        /* [2] ���� : first�� second�� ���ؼ� ū ���� ���.
                    - ���� first�� second �̻��� ���, first���� ���
                    - �ƴ� ��� second���� ���.
        */
        if (first >= second) 
        {
            Debug.Log($"ū ���� {first}");
        }
        else
        {
            Debug.Log($"ū ���� {second}");
        }
    }
}
