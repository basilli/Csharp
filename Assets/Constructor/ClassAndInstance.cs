using Constructor;
using UnityEngine;


/* [0] 개요 : ClassAndInstance
*/


public class ClassAndInstance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 결과 : Dog Class의 인스턴스 생성.
        Dog happy = new Dog("해피");
        Debug.Log(happy.Cry());
        // [1-2] 결과 : Class가 다른 Dog의 인스턴스 생성.
        Dog Worry = new Dog("워리");
        Debug.Log(Worry.Cry());
    }
}
