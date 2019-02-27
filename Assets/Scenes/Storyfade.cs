﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Storyfade : MonoBehaviour
{
    public Image splashImage;
    public Text storyText;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        storyText.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(4.5f);
      
    }
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
        storyText.CrossFadeAlpha(1.0f, 1.5f, false);


    }

}
