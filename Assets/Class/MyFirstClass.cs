using UnityEngine;


/* [0] ���� : MyFirstClass
*/

public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1-1] ���� : static(����) �޼��� ȣ�� �� StaticMethod( ) ȣ��.
         */
        ClassMember.StaticMethod();     // ) Ŭ�����̸�( ).�޼����̸� ( )
        // ClassMember.InstanceMethod();        // ) NG.

        /* [1-2] ���� : Instance �޼��� ȣ�� �� InstanceMethod( ) ȣ��.
                - new ��� Ű���带 �̿��Ͽ� ���ο� ��ü�� ����.
         */
        ClassMember member = new ClassMember();     // ) (Ŭ�����̸�) ��ü�̸� = new Ŭ�����̸�( );
        member.InstanceMethod();        // ) (��ü�̸�).�޼��� �̸�.
        // member.StaticMethod();        // ) NG.
    }
}
