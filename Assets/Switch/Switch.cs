using UnityEngine;


/*
  [0] ���� : Switch
        - "1,2,3,4�� ���� �����߽��ϴ�." ��� ���.
        - 1,2,3,4�� ���� ���� ������ ��� "�߸� �����߽��ϴ�." ��� ���.
        - switch���� if�� 2������ �����Ͻÿ�.
 */
public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ����
        int answer = 7;

        // [2] ���� : if������ ����.
        if (answer == 1)
        {
            Debug.Log("1�� ���� �����߽��ϴ�. ");
        }
        else if (answer == 2)
        {
            Debug.Log("2�� ���� �����߽��ϴ�. ");
        }
        else if (answer == 3)
        {
            Debug.Log("3�� ���� �����߽��ϴ�. ");
        }
        else if (answer == 4)
        {
            Debug.Log("4�� ���� �����߽��ϴ�. ");
        }
        else
        {
            Debug.Log("�߸� �����߽��ϴ�. ");
        }
    }
}

/*
 
// [1] ����   
int answer = 5;

// [2] ���� : switch������ ����.
switch (answer)
{
    case 1:
        Debug.Log("1�� ���� �����߽��ϴ�. ");
        break;
    case 2:
        Debug.Log("2�� ���� �����߽��ϴ�. ");
        break;
    case 3:
        Debug.Log("3�� ���� �����߽��ϴ�. ");
        break;
    case 4:
        Debug.Log("4�� ���� �����߽��ϴ�. ");
        break;
    default:
        Debug.Log("�߸� �����߽��ϴ�. ");
        break;
}

*/
