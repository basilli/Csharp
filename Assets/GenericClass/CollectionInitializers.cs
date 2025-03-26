using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* [0] 개요 : CollectionInitializers
 		- using System.Collections;을 상부에 추가할 것.
		- using System.Collections.Generic;을 상부에 추가할 것.
*/

namespace GenericClass
{
    // [1-1] 정의 : Person 선언
    public class Person
    {
    public string Name { get; set; }
    }

    public class CollectionInitializers : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의 : 고객전용 List
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동"},
                new Person { Name = "백두산"},
                new Person { Name = "장길산"},
            };

            // [2] 결과 :
            foreach (var p in people)
            {
                Debug.Log(p.Name);
            }
        }
    }
}
