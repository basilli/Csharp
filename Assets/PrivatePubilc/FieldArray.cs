using PrivatePublic;
using UnityEngine;

public class FieldArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 
        Schedule schedule = new Schedule();
        schedule.PrintWeekDays();
    }
}
