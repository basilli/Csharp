using UnityEngine;


/* [0] ���� : EnumAnimal
        - �������� �����ϴ� ������ ����.
*/

// [1] ����
enum Animal     // ) Animal�̶� ���� �̸��� �ٸ� ��ũ��Ʈ�� ������ NG�� ����.
{ 
    Mouse,
    Cow,
    Tiger,
}

public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] ���� : ������ ���� ���� �� �ʱ�ȭ.
        Animal animal = Animal.Tiger;

        // [3-1] ���
        Debug.Log(animal);

        // [3-2] ��� : ���ǹ����� ���ǽ�.
        if (animal == Animal.Tiger)
        {
            Debug.Log("ȣ����");
        }
    }
}
