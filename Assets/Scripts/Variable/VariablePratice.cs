using UnityEngine;

public class VariablePratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1, number2, number3;
        number1 = 10;
        number2 = 20;
        number3 = 30;

        Debug.Log(number1 + "," + number2 + "," + number3);

        int first = 10;
        int second = 20;
        int third = 30;

        Debug.Log(first + "," + second + "," + third);
    }
}


/*
 [Q]
    ���� : first, second, third �����ϰ� �� �����Ͽ� �Ʒ� ���� ���

 [Output]
    10, 20, 30
*/