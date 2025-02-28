using UnityEngine;

public class Singnedingeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // SignedIngeger
        sbyte iSbyte = 127; // 8��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767; // 16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int int32 = 2147483647; // 32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 = 9223372036845775807; // 64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("sbyte" + iSbyte);
        Debug.Log("short" + iInt16);
        Debug.Log("int" + int32);
        Debug.Log("long" + iInt64);


        // UnSignedIngeger
        byte iBtye = 255; // 8��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        ushort iUInt16 = 65535; // 16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        uint iUint32 = 4294967295; // 32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        ulong iUInt64 = 18446744073709551615; // 64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("byte" + iBtye);
        Debug.Log("ushort" + iUInt16);
        Debug.Log("uint" + iUint32);
        Debug.Log("ulong" + iUInt64);

    }

}

/*
 1 Bit�� 0�� 1�� �˰�����
 1 Byte�� 8bit���� ������
    0000 0000 �� 0
    0000 0001 �� 1
    0000 0010 �� 2
    0000 0011 �� 3
    0000 0100 �� 4

 8bite
    sbyte : -128~127���� ���, ��ȣ�� ���� �� (+, -, 0)
    byte : 0~255 ���, ��ȣ�� ���� �� (+, 0)
*/


/*
 SignedIngeger (+,-) ��ȣ�� �ִ� ������ ������ ����(Ÿ��)
 UnSignedIngeger (+,-) ��ȣ�� ���� ������ ������ ����(Ÿ��) �� -���� �������� �ʴ� ������
*/