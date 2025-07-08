using System;
using UnityEngine;

public class Button : MonoBehaviour
{
    public static bool buttonIsAlive = false; //버튼 활성화유무
    public static bool objectMoveFade; //버튼 누를시 페이드와 이동
    public static bool objectMove; // 이동만
    private void Update()
    {
        if (buttonIsAlive)
        {
            if (Input.GetKeyDown(KeyCode.F) && Interect.interectFade)
            {
                FadeMotion.FadeOut = true;
                objectMoveFade = true;
            }
            else if(Input.GetKeyDown(KeyCode.F))
            {
                objectMove = true;
            }
        }
        if (!buttonIsAlive)
        {
            Destroy(gameObject);
        }
    }
}
