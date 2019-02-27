using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FadeProlog : MonoBehaviour
{
    public Image splashImage;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(4.5f);


    }
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(0.0f, 4.5f, false);


    }
}
