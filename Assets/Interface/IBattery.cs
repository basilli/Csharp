using UnityEngine;

/* [0] 개요 : IBattery
*/

namespace Interface
{
    // [1-1] 정의 : Interface 선언.
    public interface IBattery
	{
        // [1-2] 정의 : Method 선언 및 구현부 생략. → Interface에서는 Public가 기본임.
        string GetName();
	}
    // [1-3] 정의 : I
    public class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }
    // [1-4] 정의 
    public class Bad : IBattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }
    // [1-5] 정의 
    public class HdCar
    {
        // [1-5-1] 정의 : Field
        private IBattery battery;
        // [1-5-2] 정의 : Constructor
        public HdCar(IBattery _battery)
        {
            this.battery = _battery;
        }
        // [1-5-3] 정의 : 
        public void Run()
        {
            Debug.Log($"{battery.GetName()} 배터리를 장착한 차가 달린다.");
        }
    }
}