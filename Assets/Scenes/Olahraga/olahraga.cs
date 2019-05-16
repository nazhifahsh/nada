using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class olahraga : MonoBehaviour
{
    public Animator mblo;

    public void o1()
    {
        mblo.SetBool("o1", true);
    }
    public void o2()
    {
        mblo.SetBool("o2", true);
    }
    public void o3()
    {
        mblo.SetBool("o3", true);
    }
    public void o6bye()
    {
        mblo.SetBool("o6bye", true);
    }
    public void poo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }
}
