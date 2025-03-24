using UnityEngine;
using static Override.CarBase;

/* [0] 개요 : InheritancePractice
*/


namespace Override
{

    public class InheritancePractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 결과 : HyunDai Class의 인스턴스 생성 01.
            HyunDai hd = new HyunDai();
            Debug.Log($"{hd.Style}");
            hd.Go();
            hd.Back();
            hd.Left();
            // [1-2] 결과 : HyunDai Class의 인스턴스 생성 02.
            HyunDai hdE = new HyunDai(CarType.전기);
            Debug.Log($"{hdE.Style}");
            hdE.Go();
            hdE.Back();
            hdE.Left();



            // [2-1] 결과 : Tesla Class의 인스턴스 생성 01.
            Tesla ts = new Tesla();
            Debug.Log($"{ts.Style}");
            ts.Go();
            ts.Back();
            ts.Left();



            // [3-1] 결과 : Mirea Class의 인스턴스 생성 01.
            Mirea mr = new Mirea();
            Debug.Log($"{mr.Style}");
            mr.Go();
            mr.Back();
            mr.Left();
        }
    }
}
