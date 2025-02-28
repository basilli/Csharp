using UnityEngine;

public class Singnedingeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // SignedIngeger
        sbyte iSbyte = 127; // 8비트 부호가 있는 정수형 변수 선언 및 초기화
        short iInt16 = 32767; // 16비트 부호가 있는 정수형 변수 선언 및 초기화
        int int32 = 2147483647; // 32비트 부호가 있는 정수형 변수 선언 및 초기화
        long iInt64 = 9223372036845775807; // 64비트 부호가 있는 정수형 변수 선언 및 초기화

        Debug.Log("sbyte" + iSbyte);
        Debug.Log("short" + iInt16);
        Debug.Log("int" + int32);
        Debug.Log("long" + iInt64);


        // UnSignedIngeger
        byte iBtye = 255; // 8비트 부호가 있는 정수형 변수 선언 및 초기화
        ushort iUInt16 = 65535; // 16비트 부호가 있는 정수형 변수 선언 및 초기화
        uint iUint32 = 4294967295; // 32비트 부호가 있는 정수형 변수 선언 및 초기화
        ulong iUInt64 = 18446744073709551615; // 64비트 부호가 있는 정수형 변수 선언 및 초기화

        Debug.Log("byte" + iBtye);
        Debug.Log("ushort" + iUInt16);
        Debug.Log("uint" + iUint32);
        Debug.Log("ulong" + iUInt64);

    }

}

/*
 1 Bit는 0과 1만 알고있음
 1 Byte는 8bit으로 구성됨
    0000 0000 → 0
    0000 0001 → 1
    0000 0010 → 2
    0000 0011 → 3
    0000 0100 → 4

 8bite
    sbyte : -128~127까지 사용, 부호가 있음 → (+, -, 0)
    byte : 0~255 사용, 부호가 없음 → (+, 0)
*/


/*
 SignedIngeger (+,-) 부호가 있는 정수형 데이터 형식(타입)
 UnSignedIngeger (+,-) 부호가 없는 정수형 데이터 형식(타입) → -값을 저장하지 않는 데이터
*/