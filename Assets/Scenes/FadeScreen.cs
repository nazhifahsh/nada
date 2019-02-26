﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FadeScreen : MonoBehaviour
{
    public Image splashImage;
    public Text splashText;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        splashText.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(4.5f);
        FadeOut();
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(loadLevel);

    }
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
        splashText.CrossFadeAlpha(1.0f, 1.5f, false);

    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 4.5f, false);
        splashText.CrossFadeAlpha(0.0f, 4.5f, false);

    }
}
