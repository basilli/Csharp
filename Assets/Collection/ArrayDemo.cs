using UnityEngine;


/* [0] ���� : ArrayDemo
		- Collection(�÷���)
            - �迭ó�� Ư�� �׸��� ������ �����ϴ� �׸�.
		    - �迭, ����Ʈ, ��ųʸ� ���� ����� ���� ��ü�� �׷��� ����� ������.
*/


public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        string[] colors = { "Red", "Green", "Blue" };

        // [2] ����
        Debug.Log($"�迭�� ��Ҽ� ���� : {colors.Length}");
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }
}
