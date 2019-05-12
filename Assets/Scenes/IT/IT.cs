using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IT : MonoBehaviour
{
    public Animator hehe;
     
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
