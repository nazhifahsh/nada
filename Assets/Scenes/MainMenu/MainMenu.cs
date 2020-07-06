using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Animator ye;

    public void story()
    {
        ExampleCoroutine();
        ye.SetBool("story", true);
    }
    public void storyy()
    {
        ye.SetBool("story", false);
    }
    public void PlayGame()
    {
      
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void OpenChapter()
    {
        ExampleCoroutine();
        SceneManager.LoadScene("Chapter");
    }

    public void Settings()
    {
        ExampleCoroutine();
        SceneManager.LoadScene("Settings");
    }

    public void About()
    {
        ExampleCoroutine();
        SceneManager.LoadScene("About");
    }

    public void QuitGame()
    {
        ExampleCoroutine();
        Debug.Log("Quit");
        Application.Quit();
    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1);

    }
}
