using UnityEngine;


/* [0] ���� : StringNote
*/


public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : string ���� ���� + ������ �ʱ�ȭ.
        string str = "";
        str = System.String.Empty;		// ) �� ������ ����. (null�� �ƴ�)
        str = " Abc Def Fed Cba ";      // )  ���ڿ� ��,�ڿ� ������ �ϳ��� �־ ���� ������.

        // [2-1] ���
        Debug.Log(str);
        Debug.Log(str.Length);		// ) ���ڿ��� ���� ���ϱ�.
        Debug.Log(str[5]);		// ) ���ڿ����� 'D'�� ���.
        Debug.Log(str.ToUpper());       // ) �빮�ڷ� �ٲٱ�.
        Debug.Log(str.ToLower());       // ) �ҹ��ڷ� �ٲٱ�.
        // [2-2] ��� : ��������.
        Debug.Log(str.Trim());      // ) �յ� ���ʿ� �ִ� ������ ����.
        Debug.Log(str.TrimStart());      // ) ���ڿ� �տ� �ִ� ���� ����.
        Debug.Log(str.TrimEnd());      // ) ���ڿ� �ڿ� �ִ� ���� ����.
        // [2-3] ��� : �˻�.
        Debug.Log(str.IndexOf('e'));     // ) ���ڿ� �� 'e'�� ��ġ�� �ε����� ��������.
        Debug.Log(str.Substring(5, 3));     // ) 5�� �ε���(D)���� 3���� ��������. �� ���ڿ� �Ϻ� ��������.
        Debug.Log(str.Substring(5));       // ) 5�� �ε���(D)���� ������ ��������.
        Debug.Log(str.Remove(5,3));     // ) 5�� �ε���(D)���� 3���� ����.
        // [2-4] ��� : ��.
        Debug.Log(str[1] == str[15]);       // ) 1�� �ε����� 15�� �ε����� ������ ���ϱ�. �� false
        Debug.Log("ABC".Equals("Abc"));     // ) �빮�ڿ� �ҹ��� ���ϱ�. �� false
        Debug.Log(System.String.Compare("BAC", "Bac"));        // ) ������ 0, �ٸ��� 1(���� ���� Ŭ ���)�̳� -1(���� ���� ���� ���).
        // [2-4] ��� : ����.
        var hi1 = "�ȳ�";
        var hi2 = "�ϼ���";
        Debug.Log(hi1 + hi2);
        Debug.Log($"{hi1}{hi2}");
        // [2-5] ��� : Format�� ���.
        Debug.Log(System.String.Format("{0}{1}", hi1, hi2));
        Debug.Log(System.String.Format("{0:C}", 1000));     // ) C = ��ȭ��(\)�� ����.
        Debug.Log(System.String.Format("{0:#,###}", 1000000));     // ) 3�ڸ��� , ���.
        // [2-6] ��� : �и��ϱ�.
        string[] strArray = str.Trim().Split(' ');      // ) Trim�� ���� ��, Split�� ������ �� ���ڿ� ��ü�� ������ ������.
        string strAll = "";
        foreach (var s in strArray)
        {
            // Debug.Log(s);
            strAll = strAll + s;
        }
        Debug.Log(strAll);
    }
}
