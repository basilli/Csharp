using UnityEngine;


/* [0] ���� : RandomDemo
		- Random Class : �������� ���õ� ������ �޼��尡 �ִ� Class.
*/

public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] ���� : Ŭ������ ��ü ����.
        System.Random random = new System.Random();

        // [2-1] ��� : ������ ������ ���ϱ�.
        Debug.Log(random.Next());
        // [2-2] ��� : 0~4 �� �ϳ��� ���� ���ϱ�.
        Debug.Log(random.Next(5));
        // [2-3] ��� : 1~9 �� �ϳ��� ���� ���ϱ�.
        Debug.Log(random.Next(1, 10));      // ) ������ ���� ���� ���� ���� ū ��(���ϴ� ���� �ʰ�)�� �Է�.
        // [2-4] ��� : -10~0 �� �ϳ��� ���� ���ϱ�.
        Debug.Log(random.Next(-10, 1));
        // [2-5] ��� : 1.1~1.9 �� �ϳ��� ���� ���ϱ�.
        // Debug.Log(random.NextDouble(1.1, 1.9));      // ) NextDouble�� ������ �ٲٰ� ���� �߰��ؾ���.
    }
}
