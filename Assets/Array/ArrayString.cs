using UnityEngine;


/* [0] ���� : ArrayString
        - string : ������ (��)��. �� Array(�迭)�� ������ ����.
 */
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        string arr = "C#8";

        // [2] ���
        Debug.Log(arr.Length);
        Debug.Log(arr[0]);       // ) C�� �Էµ�.
        Debug.Log(arr[1]);       // ) #�� �Էµ�.
        Debug.Log(arr[2]);       // ) *�� �Էµ�.
    }
}
