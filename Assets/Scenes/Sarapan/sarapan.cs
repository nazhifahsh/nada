using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sarapan : MonoBehaviour
{
    public Animator bebek;
    public AudioSource itik;

    public void o1()
    {
        bebek.SetBool("s1", true);
    }
    public void o2()
    {
        bebek.SetBool("s2", true);
    }
    public void o3()
    {
        bebek.SetBool("s3", true);
    }
    public void o4()
    {
        bebek.SetBool("s4", true);
    }
    public void o5()
    {
        bebek.SetBool("s5", true);
    }
    public void o6()
    {
        bebek.SetBool("s6", true);
    }
    public void o7()
    {
        bebek.SetBool("s7", true);
    }
    public void o35()
    {
        bebek.SetBool("s35", true);
    }
    public void o8()
    {
        bebek.SetBool("s8", true);
    }
    public void o9()
    {
        bebek.SetBool("s9", true);
    }
    public void o10()
    {
        bebek.SetBool("s10", true);
    }
    public void pindah()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void blwe()
    {
        itik.Play();
    }
}
