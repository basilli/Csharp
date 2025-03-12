using UnityEngine;


/* [0] ���� : RandomPractice
		- [Q]
            - �ζ� ��ȣ �����⸦ ����ÿ�.
            - 1��~45�� ������ ������ȣ �߿��� ���� �ٸ� 6���� ��÷��ȣ�� ���Ͻÿ�.

		- [output]
            - ���ǿ� �´� ��ȣ6���� ����Ͻÿ�.
*/

public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : Random Class ��ü ����.
        System.Random rand = new System.Random();
        // [1-1] ���� : �迭 ���� ���� �� ��Ҽ� ����.
        int[] numbers = new int[6];
        // [1-2] ���� : �������� �����ϴ� ����.
        int number = 0;
        // [1-3] ���� : �ߺ��˻縦 �����Ͽ��� �� �ߺ��̸� true, �ƴҰ�� false.
        bool flag = false;

        // [2-1] ����
        for (int i = 0; i < 6; i++)
        {
            // [2-1-1]
            number = rand.Next(1, 46);      // ) 1~46������ �������� �޾ƿ�.
            flag = false;       // ) �ߺ�üũ. number�� ���� ���� �ζǹ�ȣ�� �񱳸� �Ͽ� �˻縦 ������.
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;        // ) false�� ��� ���ѷ����� �ɸ��⶧����, ��� ������ true�� �Ǿ�� ��.
                    }
                }
            }
            // [2-1-2]
            if (flag == false)      // ) �ߺ��� �ƴ� ���.
            {
                numbers[i] = number;
            }
            else      // ) �ߺ��� ���, �ٽ� ����� �ؾ��ϱ� ������ �ε����� �����ؾ� ��.
            {
                i--;
            }
        }
        // [3] ��� : �ζǹ�ȣ ���.
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}

/*
          number[0] : �ߺ��˻� X.
          number[1] : [0]
          number[2] : [0], [1]
          number[3] : [0], [1], [2]
          number[4] : [0], [1], [2], [3]
          number[5] : [0], [1], [2], [3], [4]
          number[6] : [0], [1], [2], [3], [4], [5]

*/