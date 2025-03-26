using UnityEngine;
using System.Collections;

/* [0] 개요 : MyList
		- 
		- 
		- 
		- 
		- 
*/
namespace GenericClass
{
// [1-1] 정의 : Array 데이터를 저장하는 GenericClass 만들기
    public class MyList<T>
	{
	// [1-2] 정의 : Field
		private T[] values;
		private int _length;
        public int Length
        {
            get { return _length; }
        }
	// [1-3] 정의 : Constructor → Method를 길이로 입력받아 Array 변수 생성.
		public MyList(int length)
		{
			this._length = length;
			values = new T[length];
		}

	// [1-4] 정의 : Indexer(인덱서)
		public T this[int index]
		{
			get { return values[index]; }
			set { values[index] = value; }
		}

	// [1-5] 정의 : 반복기
		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < _length; i++)
			{
				yield return values[i];
			}
		}
    }
}