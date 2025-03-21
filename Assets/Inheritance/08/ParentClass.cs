using UnityEngine;


/* [0] 개요 : ParentClass
*/

namespace Inheritance08
{
    // [1-1] 정의 : AbstractClass
    public abstract class ParentClass
    {
        public int ID { get; set; }
        public bool Active { get; set; }
    }
    // [1-2] 정의 : ChildClass : AbstractClass를 상속받음.
    public class ChildClass : ParentClass
    { 
    public string Name { get; set; }
    }
}
