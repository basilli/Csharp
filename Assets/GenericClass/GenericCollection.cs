using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* [0] 개요 : GenericCollection
 		- using System.Collections;을 상부에 추가할 것.
		- using System.Collections.Generic;을 상부에 추가할 것.
*/

namespace GenericClass
{
    // [1-1] 정의 : Student 선언.
    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    /*
    // [1-2] 정의 : GenericClass(List<T>)
            - 형식 매개변수 T에 지정한 형식으로 Class와 Member의 성질을 결정하는 Class.
            - List<T> => int, float, string, Class(사용자 정의 형식)
    */
    public class GenericCollection : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-3] 정의 : 학생전용 List
            List<Student> students = new List<Student>
            {
            new Student{ Name = "홍길동", Number = 1},
            new Student{ Name = "백두산", Number = 2},
            new Student{ Name = "장길산", Number = 3}
            };

            // [1-4] 정의 : 새로운 학생을 List에 추가.
            Student student = new Student() { Name = "김단비", Number = 4 };
            students.Add(student);

            // [1-5] 결과 : 
            foreach (var s in students)
            {
                Debug.Log($"{s.Name} - {s.Number}");
            }
        }
    }
}