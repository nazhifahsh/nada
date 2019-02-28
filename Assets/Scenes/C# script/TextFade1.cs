using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextFade1 : MonoBehaviour
{
    public Text splashText;
    public string loadLevel;

    IEnumerator Start()
    {
        splashText.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(1.5f);
       

    }
    void FadeIn()
    {
        splashText.CrossFadeAlpha(0.5f, 1.0f, false);


    }

    void FadeOut()
    {
        splashText.CrossFadeAlpha(0.0f, 4.5f, false);

    }
}
