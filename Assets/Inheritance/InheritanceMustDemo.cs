using Constructor;
using Unity.VisualScripting;
using UnityEngine;

/* [0] 개요 : InheritanceMustDemo
*/

namespace Inheritance09
{
    public class InheritanceMustDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 결과 : Person의 인스턴스 생성.
            Person person = new Person();
            person.SayTalk();
        }
    }
}
