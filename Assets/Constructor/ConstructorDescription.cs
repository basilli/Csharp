using UnityEngine;


/* [0] 개요 : ConstructorDescription
		- Constructor(생성자) : Class가 사용될 때, 가장 먼저 호출되는 메서드.
		- 인스턴스를 생성할 때, 제일 먼저 호출되는 메서드.
		- Class Field의 기본값을 설정하는 역할. → 초기화.
        - Constructor 이름이 Class 이름과 동일해야함.
        - Public 접근 제한자를 사용함.
        - 반환값이 없고, Void도 없음.
		- 형태.
            class ClassName(클래스이름)
            {
                // Constructor(생성자) 정의
                    public ClassName( )     // ) ClassName이 그대로 와서 생성자 이름이 됨.
                    {
                    
                    }
            }
        - 모든 Class는 Constructor를 가지고 있음.
		- Constructor를 만들지 않을 경우, 기본 Constructor를 자동으로 만들어 줌.
        - 기본 Constructor의 형태
            public 클래스이름( )
            {
            
            }
*/

namespace Constructor
{


    public class ConstructorDescription : MonoBehaviour
    {
        // [1-1] 정의 : Constructor(생성자)
        public ConstructorDescription()
        { 
        
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의 : ConstructorDescription 인스턴스 생성.
            ConstructorDescription cons = new ConstructorDescription();
        }

    }
}
