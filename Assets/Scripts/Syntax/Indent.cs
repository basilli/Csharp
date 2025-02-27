using UnityEngine;

// Indent (들여쓰기) : 공백 4칸을 사용 또는 탭 사용

public class Indent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("들여쓰기는 공백 4칸을 사용합니다");
        Debug.Log("들여쓰기는 탭을 사용합니다");
            Debug.Log("Hello World!");
                Debug.Log("Hello World!!");
                    Debug.Log("Hello World!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
