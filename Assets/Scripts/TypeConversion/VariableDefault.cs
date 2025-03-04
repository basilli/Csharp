using UnityEngine;

public class VariableDefault : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수 선언하고 default(기본값)값으로 초기화
        int i = default;
        double d = default;
        string s = default;
        char c = default;
            // Debug.Log($"[{i}],[{d}],[{s}],[{c}]");
        Debug.Log($"[{i}],[{d}],[{s == null}],[{c == System.Char.MinValue}]");

    }
}
