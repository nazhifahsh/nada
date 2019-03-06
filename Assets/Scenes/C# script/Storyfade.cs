using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Storyfade : MonoBehaviour
{

    public Image splashImage;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(3.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(loadLevel);

    }
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.0f, false);
    }
    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 4.5f, false);
    }
}

