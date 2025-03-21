using UnityEngine;

/* [0] 개요 : Parent
*/

namespace Inheritance06
{
    public class Parent
    {
        // [1-1] 정의 : ParentClass
        public string Word { get; set; }

        // [1-2] 정의 : Constructor
        public Parent(string word)
        {
            this.Word = word;
        }
    }
}
