using UnityEngine;


/* [0] ���� : SquareClass
*/

public class SquareClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] ���� : Ŭ������ static(������) �޼��� GetName( ) ȣ��.
                - ����
                    ���� �޼����� ȣ�� ��� : Ŭ�����̸�(Square).�޼����̸� (GetName)
        */
        string name = Square.GetName();
        Debug.Log(name);
    }
}
