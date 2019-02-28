using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image splashImage;
    public void PlayGame()
    {
      
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 5.5f, false);

    }
}
