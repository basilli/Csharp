using UnityEngine;


/* [0] ���� : EnumSwitch
		- �������� Switch���� �Բ� ���� ����.
		- �ѱ� ���� �̸��� ����Ͻÿ�.
*/

// [1] ����
enum Animalw
{ 
    Chicken,
    Dog,
    Pig
}


public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-2] ���� : ������ ���� ���� �� �ʱ�ȭ
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);

    }
    // [2-1] ���� : �Ű������� ������ ������ �޾� �ѱ� �̸��� ���.
    void PrintAnimal(Animalw animal)
    {
        // [3] ���
        switch (animal)
        {
            case Animalw.Chicken:
                Debug.Log("�R");
                break;
            case Animalw.Dog:
                Debug.Log("��");
                break;
            case Animalw.Pig:
                Debug.Log("����");
                break;
        }
    }
}
