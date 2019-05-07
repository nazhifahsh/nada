using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public void bihun()
    {
        he.yoi += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void mie()
    {
        he.yoi += 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
