﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeKeberangkatan4 : MonoBehaviour
{

    public Image splashImage;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
       


    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 2.5f, false);


    }
}
