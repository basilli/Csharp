using UnityEngine;


/* [0] ���� : ForIncrement(������)
        - 0���� 10���� ī������ �ϵ�, 2�� �����ϸ鼭 ����ϵ��� �� ��.
        - 0,2,4 ... 8,10
 */
public class ForIncrement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        for (int i = 0; i < 11; i = i+2)
        {
            Debug.Log(i);
        }
    }
}
