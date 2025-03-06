using UnityEngine;


// [0] °³¿ä : SwitchStatement
public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Á¤ÀÇ
        Debug.Log(" ¿À´Ã ³¯¾¾´Â ¾î¶²°¡¿ä? (¸¼À½, Èå¸², ºñ, ´«) ");
        string weather = "¸¼";

        // [2] °¡Á¤
        switch (weather)
        {
            case "¸¼À½":
                Debug.Log(" ¿À´Ã ³¯¾¾´Â ¸¼½À´Ï´Ù. ");
                break;
            case "Èå¸²":
                Debug.Log(" ¿À´Ã ³¯¾¾´Â Èå¸³´Ï´Ù. ");
                break;
            case "ºñ":
                Debug.Log(" ¿À´Ã ³¯¾¾´Â ºñ°¡ ³»¸³´Ï´Ù. ");
                break;
            default:    // ¸¼À½, Èå¸², ºñ·Î ÀûÁö¾Ê¾ÒÀ» °æ¿ì, ¹«Á¶°Ç ´«À¸·Î Ç¥±âµÊ.
                Debug.Log(" ¿À´Ã ³¯¾¾´Â ´«ÀÌ ³»¸³´Ï´Ù. ");
                break;
        }
    }
}
