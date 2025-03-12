using UnityEngine;


/* [0] ���� : DateTimeDemo
        - ������ ����ü (DateTime) ���.
		- ��¥ �� �ð� ������ �����ϰ� ������ �� �ִ� ����ü.
		- ��¥�� �ð��� �ٷ� �� ��, ��, ��, ��, ��, �� ���� ������ ������.
		- ��¥�� ���ϰų�, ���ϰų�, ������ �ٲ㼭 ����ϴ� ����� ����.
		- DateTime.Now (������ýð�), DateTime.UtcNow (���� UTC �ð�), DateTime.Today(���� ��¥) �� ���� ������ �Ӽ��� ����.
*/
public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] ���� �� ��� : ����ð��� ���.
        Debug.Log($"����ð� : {System.DateTime.Now}");

        // [1-2] ���� �� ��� : ���� ��, ��, ��, ��, ��, �ʸ� ���.
        Debug.Log(System.DateTime.Now.Year);
        Debug.Log(System.DateTime.Now.Month);
        Debug.Log(System.DateTime.Now.Day);
        Debug.Log(System.DateTime.Now.Hour);
        Debug.Log(System.DateTime.Now.Minute);
        Debug.Log(System.DateTime.Now.Second);

        // [2] ���� : DateTime ����ü ������ �����ؼ� ���.
        System.DateTime now = System.DateTime.Now;

        // [3] ���
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());
    }
}
