using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FadeScreen : MonoBehaviour
{
    public Image splashImage;
    public Image splashImage2;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        splashImage2.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(4.5f);
        FadeOut();
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(loadLevel);

    }
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
        splashImage2.CrossFadeAlpha(1.0f, 1.5f, false);


    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 4.5f, false);
        splashImage2.CrossFadeAlpha(0.5f, 4.5f, false);


    }
}
