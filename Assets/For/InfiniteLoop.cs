using UnityEngine;


/* [0] ���� : InfiniteLoop(���ѷ���)
        - ���� ���� �ʴ� �ݺ�����.(=����)
        - ���� �� ���, �������Ḧ �ؾ���.
        - �ݺ����� ���� ���, �������� �� �ִ� ������ ��������.
 */
public class InfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (; ; )
        {
            Debug.Log("���ѷ���");
        }
    }
}
