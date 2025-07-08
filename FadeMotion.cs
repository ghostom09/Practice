using UnityEngine;
using UnityEngine.UI;

public class FadeMotion : MonoBehaviour
{
    private Image image;
    public static bool FadeIn;
    public static bool FadeOut;
    private float time = 0;

    void Start()
    {
        image = GetComponent<Image>();
    }
    // void Update()
    // {
    //     Color color = image.color;
    //     if (FadeOut)
    //     {
    //         color.a += Time.deltaTime;
    //         time += 1;
    //     }
    //
    //     if (time > 150)
    //     {
    //         FadeIn = true;
    //         FadeOut = false;
    //         time = 0;
    //     }
    //     if (FadeIn)
    //     {
    //         color.a -= Time.deltaTime;
    //     }
    //     image.color = color;
    // }
}
