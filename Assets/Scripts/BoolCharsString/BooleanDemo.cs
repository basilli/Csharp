using UnityEngine;

// bool (불) : 불형, 논리자료형, 참(true) OR 거짓(false) 값만 저장함
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] bool 변수선언 후, 초기화
        bool bln = true;
            Debug.Log("bln : " + true);

        bool isOut = false;
            Debug.Log("isOut : " + false);
    }


}
