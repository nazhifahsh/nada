﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diari : MonoBehaviour
{

    public Animator hiya;
    public void sl1()
    {
        hiya.SetTrigger("s1");
    }
    public void sl2()
    {
        hiya.SetTrigger("p");
    }
    public void sl3()
    {
        hiya.SetBool("s3", true);
    }
    public void sl4()
    {
        hiya.SetBool("s4", true);
    }
    public void sl5()
    {
        hiya.SetBool("s5", true);
    }
    public void udh()
    {
        hiya.SetBool("bay", true);
    }
    public void skip()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
