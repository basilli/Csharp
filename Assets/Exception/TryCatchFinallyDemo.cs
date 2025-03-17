using UnityEngine;


/* [0] ���� : TryCatchFinallyDemo
		- try������ ���ܰ� �߻��� ��� : [1] �� [2] �� [3]
		- try������ ���ܰ� �߻����� �ʾ��� ��� : [1] �� [3]
*/

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int x = 5;
        int y = 0;
        int r = 0;

        // [2] ����
        try		// ) ���ܰ� �߻��� ���ɼ��� �ִ� ��ɹ�.
        {
            // [2-1]
            r = x / y;
            Debug.Log($"{x} / {y} = {r}");
        }
        catch		// ) try������ ���ܰ� �߻��� ���, catch���� ������.
        {
            // [2-2]
            Debug.Log("���ܰ� �߻��Ͽ����ϴ�.");
        }
        finally		// ) try������ ���ܰ� �߻��ϰų� �����ʾƵ� ������� ������.
        {
            // [2-3]
            Debug.Log("���α׷��� �����մϴ�.");
        }
    }
}
