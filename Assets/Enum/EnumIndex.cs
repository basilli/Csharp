using UnityEngine;


/* [0] ���� : EnumIndex
		- ������ ���� �������̳� ���ڿ��� ����� ����.
*/

// [1] ����
enum Animals
{
    Rabbit,
    Dragon,
    sanke,
}
public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ���� : ������ ���� ���� �� �ʱ�ȭ.
        Animals animals = Animals.Dragon;
        int num = (int)animals;
        string str = animals.ToString();

        // [3] ���
        Debug.Log($"Animals.Dragon : {num}, {str}");
    }
}
