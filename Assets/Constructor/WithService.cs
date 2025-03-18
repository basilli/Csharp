using UnityEngine;


/* [0] 개요 : WithService
*/

namespace Constructor
{
	public class WithService
	{
		// [1-1] 정의 : 읽기전용 Field.
		private readonly string serviceName;
		// [1-2] 정의 : Constructor(생성자), 읽기전용 Field 초기화 가능.
		public WithService()
		{
			serviceName = "파일";
		}
        public WithService(string _name)
        {
            serviceName = _name;
        }
		public void Run()
		{
			// )	 serviceName = "File"; → NG.
			Debug.Log($"{serviceName}를 실행합니다.");
		}
    }
}
