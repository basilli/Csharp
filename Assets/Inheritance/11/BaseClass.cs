using TMPro;
using UnityEngine;

/* [0] 개요 : BaseClass
*/

namespace Inheritance11
{
    // [1-1] 정의 : ParentClass
    public class BaseClass
    {
        // [1-2] 정의 : Field → 기본적으로 Private로 설정.
        private string word;
        // [1-3] 정의 : ParentClass → 상속받은 ChildClass에서만 접근이 가능.
        protected string Word 
        {
            get { return word; }
            set { word = value; }
        }
    }

    // [2-1] 정의 : ChildClass
    public class SubClass : BaseClass       // ) BaseClass를 상속받는 ChildClass.
    {
        public void SetWord(string _word)
        {
            base.Word = _word;
        }
        public string GetWord()
        {
            return base.Word;
        }
    }
}
