using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sarapan : MonoBehaviour
{
    public Animator bebek;
    public Animator kodok;

    public void o2()
    {
        bebek.SetBool("2", true);
    }
    public void o3()
    {
        bebek.SetBool("3", true);
    }
    public void o4()
    {
        bebek.SetBool("4", true);
    }
    public void o5()
    {
        bebek.SetBool("5", true);
    }
    public void o6()
    {
        bebek.SetBool("6", true);
    }
    public void o7()
    {
        bebek.SetBool("7", true);
    }
    public void o75()
    {
        bebek.SetBool("7.5", true);
    }
    public void o8()
    {
        bebek.SetBool("8", true);
    }
    public void fadein()
    {
        kodok.SetBool("fade", false);

    }
    public void fadeout()
    {
        kodok.SetBool("fade", true);

    }
    public void pindah()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
