using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thps : MonoBehaviour
{
    public Animator ayam;

    public void a1()
    {
        ayam.SetBool("1", true);
    }
    public void a2()
    {
        ayam.SetBool("2", true);
    }
    public void a3()
    {
        ayam.SetBool("3", true);
    }
    public void a4()
    {
        ayam.SetBool("4", true);
    }
    public void a5()
    {
        ayam.SetBool("5", true);
    }
    public void ser2()
    {
        ayam.SetBool("ser2", true);
    }
    public void ser3()
    {
        ayam.SetBool("ser3", true);
    }
    public void ser4()
    {
        ayam.SetBool("ser4", true);
    }
    public void ser5()
    {
        ayam.SetBool("ser5", true);
    }
    public void a51()
    {
        ayam.SetBool("51", true);
    }
    public void a52()
    {
        ayam.SetBool("52", true);
    }
    public void a53()
    {
        ayam.SetBool("53", true);
    }
    public void fin()
    {
        ayam.SetBool("fin", true);
    }
    public void sec()
    {
        ayam.SetBool("sec", true);
    }
    public void nsec()
    {
        ayam.SetBool("sec", false);
    }
   public void lanjoot()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
