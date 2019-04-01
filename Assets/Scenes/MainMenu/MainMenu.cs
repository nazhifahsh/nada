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

    public void OpenChapter()
    {
        SceneManager.LoadScene("Chapter");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
  
}
