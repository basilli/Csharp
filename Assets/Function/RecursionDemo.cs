using UnityEngine;


/* [0] ���� : RecursionDemo
		- ����Լ� : �Լ��� �ڽ��� �ڵ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ���ϴ� �Լ�.
		- ����Լ��� �Ű����� : �Ű������� ����, ������ ��.
        - ���ѷ����� ��������������, ����Լ� �ڵ��� �ȿ��� ����Լ��� ������ �� �ִ� ������ �ʿ���.
		- �Լ��� �ڱ� �ڽ��� ȣ���ϴ� ���α׷��� ���.
		- �ݺ��� ���̵� �ݺ����� �۾��� ������ �� �ֵ��� ��.
		- ���� ������ ������ �ذ��ϴ� ����� �����. (ex. ���丮��, �Ǻ���ġ ����, DFS)
        - ����
            - �⺻ ����(Base Case) �� ��͸� ���ߴ� ����.
            - ��� ȣ��(Recursive Case) �� �ڱ� �ڽ��� �ٽ� ȣ��.

        - ���丮���� ���ϴ� �˰���(n(4!))�� ����ÿ�.
*/

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : 4! = 1*2*3*4
        Debug.Log(4 * 3 * 2 * 1);

        // [2-2] ���� : for���� �̿��� ���丮�� ���ϱ�.
        Debug.Log(FactorialFor(4));

        // [2-3] ���� : ����Լ��� �̿��� ���丮�� ���ϱ�. (n! = n*(n-1)!)
        int Factorial(int n)
        {
            // [3] ��� : 3�� �����ڸ� �̿��� ���丮�� �����.
            int Factor(int n)
            {
                /*
                if (n <= 1)
                    return1;
                return n * Factor(n - 1);
                */
                return (n>1) ? n * Factor(n - 1) : 1;
            }

            // [3] ���
            if (n == 1|| n==0)       // ) �������� �κ� �� n�� ������ �� ���, �������� �ݺ���.
            {
                return 1;       // ) ���ȣ�� �κ� �� ���丮���� ������ �������� ������ �ݺ��Ǳ⿡ �Ҿ�����.
            }
            return n * Factorial(n-1);
        }

        /*
            - 4*Factorial(3)
                Factorial(3) = 3*Factorial(2)
                    Factorial(2) = 2*Factorial(1) �� ���⼭ ���ȣ�� �κ��� �����
                        Factorial(1) = 1*Factorial(0)
                            Factorial(0) = 0*Factorial(-1)
                                Factorial(-1) = -1*Factorial(-2)
         */

        // [2-1] ���� : for���� �̿��� ���丮�� ���ϱ�.
        int FactorialFor (int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
