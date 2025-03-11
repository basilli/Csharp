using UnityEngine;


/* [0] ���� : FunctionPractice
		- [Q]
            - ��Ģ������ ���ϴ� �Լ��� ����ÿ�.
            - �ΰ��� ������ �Է¹޾� +, -, *, /, %�� ����Ͽ� ������� ��ȯ�ϴ� �Լ��� ����ÿ�.
            - Add, Subtract, Multiply, Devide, Remainder
            - �Է°� : 5, 3
		- [output]
*/

public class FunctionPractice : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-2] ��� : Add
        int result;
        result = Add(5, 3);
        Debug.Log(result);

        // [2-2] ��� : Subtract
        result = Substract(5, 3);
        Debug.Log(result);

        // [3-2] ��� : Multiply
        result = Multiply(5, 3);
        Debug.Log(result);

        // [4-2] ��� : Devide
        result = Devide(5, 3);
        Debug.Log(result);

        // [5-2] ��� : Remainder
        result = Remainder(5, 3);
        Debug.Log(result);
    }
    // [1-1] ���� : Add
    int Add(int x, int y) => x + y;

    // [2-1] ���� : Subtract
    int Substract(int x, int y) => x - y;       // ) ' => '�� ȭ��ǥ �Լ� or ���ٽ�, ����� �Լ���� �θ�.

    // [3-1] ���� : Multiply
    int Multiply(int x, int y) => x * y;

    // [4-1] ���� : Devide
    int Devide(int x, int y) => x / y;

    // [5-1] ���� : Remainder
    int Remainder(int x, int y) => x % y;
}
