using Unity.VisualScripting;
using UnityEngine;


/* [0] ���� : StructureArray
		- ���� �����͸� �����ϴ� ����ü�� ����ÿ�.
*/

// [1] ����
struct UserInfo
{
    public string name;     // ) ���̸�
    public int age;     // ) ������
    // ETC...
}

public class StructureArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-2] ���� : ����ü ���� ����
        UserInfo info;
        // [2-3] ���� : ����ü �ʱ�ȭ
        info.name = "ȫ�浿";
        info.age = 20;
        // [2-4] ���� : ����ü ���
        PrintUserInfo(info.name, info.age);
        // [2-5] ���� : ����ü�� �迭 ���� ���� + �迭�� ��Ҽ�(ũ��) ����
        UserInfo[] userInfos = new UserInfo[2];
        // [2-6] ���� : ����ü �迭 �ʱ�ȭ
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;
        userInfos[1].name = "�Ӳ���";
        userInfos[1].age = 33;

        // [3-1] ��� : ����ü �迭 ���
        for (int i = 0; i < userInfos.Length; i++)
        {
            PrintUserInfo(userInfos[i].name, userInfos[i].age);
        }
    }
    // [2-1] ���� : �� ����� ����ϴ� �Լ�.
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴� {age}�� �Դϴ�.");
    }

    // [3-2] ���
    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}���� ���̴� {userInfo.age}�� �Դϴ�.");
    }

}
