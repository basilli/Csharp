using UnityEngine;
using System.Collections;


/* [0] ���� : ArrayListDemo
		- ArrayList�� ����Ϸ��� ��ο� ���� 'using System.Collections;�� �߰��ؾ���.
		- ArrayList Ŭ���� : �迭�� ���� ����, �迭ó�� ����� ������(�ε��� ���).
		- Add ( ) ������ �ֱ�.
*/

public class ArrayListDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : ArrayList Ŭ������ ��ü(�ν��Ͻ�) ����.
        ArrayList list = new ArrayList();

        // [2] ���� : ������ �Է�.
        list.Add("����Ư����");
        list.Add("������");

        // [3] ��� : ������ ���.
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }
    }
}
