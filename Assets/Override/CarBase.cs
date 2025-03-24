using UnityEngine;

/* [0] 개요 : CarBase
*/

namespace Override
{
	public enum CarType
	{ 
	전기,
	내연기관
	}
    // [1-1] 정의 : AbstractClass 선언
    public abstract class CarBase
	{
		// [1-2] 정의 : ParentClass
		public abstract void Left();        // ) AbstractMethod, 본문(구현내용)이 없음.
        // [1-3] 결과 : 접근제한자를 Public로 설정. → Child Class와 외부 모든 Class를 공개 및 접근,사용이 가능하게 함. 
        public void Back() => Debug.Log("후진한다.");
        // [1-4] 가정 : 접근제한자를 Protected로 설정. → Child Class에서만 접근 및 사용이 가능함.
        protected string LeftMessage { get; private set; } = "좌회전 한다.";     // ) 접근제한자를 Private로 설정. → Child Class를 포함하여 외부 모든 Class에 접근이 불가능하며, Private를 선언한 클래스 코드블록 안에서만 사용이 가능.



        // [2-1] 정의 : ChildClass
        public class Car : CarBase
        {
            // [2-4] 가정 : 모든 자동차의 공통점.
            public CarType Style { get; private set; }
            // [2-5] 가정 : Constructor → 매개변수를 입력받아 CarType 초기화.
            public Car(CarType cType)
            {
                // [2-6] 가정 : This 키워드를 이용하여 자신의 Member에 접근. → 생략되어 있음.
                this.Style = cType;
            }
            // [2-7] 결과
            public void Go() => Debug.Log("달린다.");
            // [2-2] 가정 :  Parent Abstract Method를 실제 코드로 구현 및 제정의
            public override void Left()
            {
                // [2-3] 결과 : Base 키워드를 이용하여 Parent Member에 접근. (ex. Public, Protected)
                Debug.Log(base.LeftMessage);
            }
        }



        // [3-1] 정의 : GrandsunClass01
        public class HyunDai : Car 
        {
            public HyunDai() : this(CarType.내연기관) { }
            public HyunDai(CarType carType) : base(carType) { }
        }



        // [4-1] 정의 : GrandsunClass02
        public class Tesla : Car
        {
            public Tesla() : this(CarType.전기) {}
            public Tesla(CarType carType) : base(carType) { }
        }



        // [5-1] 정의 : GrandsunClass05 → Sealed(봉인)로 SealedClass 설정하여, 상속이 더이상 안되게 함.
        public sealed class Mirea : Car 
        {
            public Mirea() : this(CarType.전기) { }
            public Mirea(CarType carType) : base(carType) { }
        }



        // [6-1] 정의 : GrandsunClass06
        // ) public class Future : Mirea { } → Sealed로 인하여 NG.
        public new void Go() => Debug.Log("난다.");
    }
}
