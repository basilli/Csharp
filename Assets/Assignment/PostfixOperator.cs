using UnityEngine;

// PostfixOperator(���� ����(++,--) ������) : ���� ���ο��� �����ϴ� ������ ���� ����. (���� ���߿� ������.)
public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;
        Debug.Log("X : " + x);
        Debug.Log("Y : " + y);
    }
}
