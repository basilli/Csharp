using UnityEngine;


/* [0] ���� : ArrayConvertAll
*/

public class ArrayConvertAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : ���ڿ� �迭�� ������ �迭�� ����.
        string[] strArray = { "10", "20", "30" };

        // [2] ����
        int[] intArray = System.Array.ConvertAll(strArray, int.Parse);

        // [3] ���
        foreach (int i in intArray)
        {
            Debug.Log(i);
        }
    }
}
