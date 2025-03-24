using UnityEngine;

/* [0] 개요 : IAnimal
*/

namespace Interface
{
    // [1-1] 정의 : Interface 선언.
    public interface IAnimal
    {
        void Eat();
    }

    // [1-2] 정의 : 
    public interface IDog
    {
        void Cry();
    }

    // [1-3] 정의 : 
    public class Cat
    { 
    }

    // [1-4] 정의 : 다른 Class 상속과 함께 Interface의 다중상속이 가능함.
    public class MyCat : Cat, IAnimal
    {
        public void Eat() { }
    }

    // [1-5] 정의 : 다른 Interface 상속과 함께 Interface의 다중상속이 가능함.
    public class Dog : IAnimal, IDog
    {
        public void Eat()
        {
            Debug.Log("먹다.");
        }
        public void Cry()
        {
            Debug.Log("울부짖다.");
        }
    }
}