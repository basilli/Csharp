using UnityEngine;


/* [0] ���� : StringSplit
		- Split( ) : ���ڿ� �и��ϱ�.
		- ���ڿ����� �Ű������� �Է¹��� Ư�� ���й��ڸ� ����Ͽ�, ���ڿ� �迭�� ����.
*/

public class StringSplit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        string scr = "Red,Green,Blue";
        string[] colors = scr.Split(',');

        // [2] ���
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }
}
