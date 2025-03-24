using Constructor;
using UnityEngine;

/* [0] 개요 : InterfaceDemo
*/

namespace Interface
{

    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : DogClass 인스턴스 생성.
            Dog dog = new Dog();
            dog.Eat();      // IAnimal Interface를 상속받아 구현.
            dog.Cry();      // IDog Interface를 상속받아 구현.
        }
    }
}