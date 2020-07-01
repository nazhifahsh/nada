using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IT : MonoBehaviour
{
    public Animator hehe;
    public Animator mboh;
    public AudioSource yoo;
     
    public void i1()
    {
        hehe.SetBool("i1", true);
    }
    public void i2()
    {
        hehe.SetBool("i2", true);
    }
    public void i3()
    {
        hehe.SetBool("i3", true);
    }
    public void i4()
    {
        hehe.SetBool("i4", true);
    }
    public void i5()
    {
        hehe.SetBool("i5", true);
    }
    public void i6()
    {
        hehe.SetBool("i6", true);
    }
    public void i7()
    {
        hehe.SetBool("i7", true);
    }
    public void ser()
    {
        SceneManager.LoadScene("Game-1",LoadSceneMode.Single);
    }
    public void ii()
    {
        hehe.SetBool("ii", true);
    }
    public void ii2()
    {
        hehe.SetBool("ii2", true);
    }
    public void ii3()
    {
        hehe.SetBool("ii3", true);
    }
    public void ii4()
    {
        hehe.SetBool("ii4", true);
    }
    public void ii5()
    {
        hehe.SetBool("ii5", true);
    }
    public void ii6()
    {
        hehe.SetBool("ii6", true);
    }
    public void ii7()
    {
        hehe.SetBool("ii7", true);
    }
    public void ii8()
    {
        hehe.SetBool("ii8", true);
    }
    public void iie()
    {
        mboh.SetBool("krang", true);
        yoo.Stop();
    }
    public void drrt()
    {
        Handheld.Vibrate();
    }
    public void krg()
    {
        yoo.Play();
    }
    public void nyanya()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
