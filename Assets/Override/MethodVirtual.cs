using UnityEngine;

/* [0] 개요 : MethodVirtual
*/

namespace Override
{
    public class MethodVirtual : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            /*
            // [1-1] 결과 : AnimalClass의 인스턴스 생성.
            Animal animal = new Animal();
            animal.Eat();

            // [1-2] 결과 : Dog의 인스턴스 생성.
            Dog dog = new Dog();
            dog.Eat();

            // [1-3] 결과 : ParentClass(Animal)의 변수에 ChildClass(Dog)의 인스턴스 생성.
            Animal dog2 = new Dog();
            dog2.Eat();

            // [1-4] 결과 : Cat의 인스턴스 생성.
            Cat cat = new Cat();
            cat.Eat();
            */

            // [2-1] 결과 : ParentClass(Animal)의 변수에 ChildClass(Dog)의 인스턴스 생성. → UpCasting(다형성)
            Animal aDog = new Dog();
            aDog.Eat();
            Animal bCat = new Cat();
            bCat.Eat();
        }
    }
}
