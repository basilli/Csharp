using UnityEngine;


/* [0] ���� : EnumIndexChange
        - �������� �������� ������� 0���� �����Ͽ� 1�� ������. (ex. 0,1,2...)
*/

// [1] ���� : �������� �����ϴ� ������ ����
enum Animale
{ 
    Horse,      // ) �ڵ������� 0���� ������.
    Sheep=5,      // ) ���������� 5�� ������.
    Monkey,      // ) �ڵ������� 6���� ������.
    Pig      // ) �ڵ������� 7���� ������.
}


public class EnumIndexChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] ���
        Debug.Log((int)Animale.Monkey);		// ) Monkey�� ���콺�� Ȯ���ϸ� ������ 6��� ���� Ȯ���� �� ����.
    }
}
