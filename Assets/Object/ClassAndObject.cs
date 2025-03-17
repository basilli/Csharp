using UnityEngine;


/* [0] 개요 : ClassAndObject
		- 개체(Object) : 설계도인 클래스로부터 만들어진 하나의 인스턴스(실체가 있으면 여러가지 구성요소로 이루어짐.)
*/

// [1-1] 정의 : ClassCode 클래스의 개체(Object) 인스턴스 만들기.
public class ClassCode
{ 
    // Empty
}

public class ClassAndObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] 가정
        ClassCode objectCode1 = new ClassCode();
        Debug.Log(objectCode1.GetHashCode());
        // [2-2] 가정
        ClassCode objectCode2 = new ClassCode();
        Debug.Log(objectCode2.GetHashCode());
    }
}
