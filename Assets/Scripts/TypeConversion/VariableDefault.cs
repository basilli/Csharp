using UnityEngine;

public class VariableDefault : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� �����ϰ� default(�⺻��)������ �ʱ�ȭ
        int i = default;
        double d = default;
        string s = default;
        char c = default;
            // Debug.Log($"[{i}],[{d}],[{s}],[{c}]");
        Debug.Log($"[{i}],[{d}],[{s == null}],[{c == System.Char.MinValue}]");

    }
}
