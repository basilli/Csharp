using UnityEngine;

// 대입 연산자를 축약해서 사용하기.
public class ShortcutOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        x = x + 2;  // x를 2 증가식.
        Debug.Log("x : " + x);

        int y = 3;
        y += 2;     // y = y + 2을 축약한 식.
        Debug.Log("y : " + y);
    }
}
