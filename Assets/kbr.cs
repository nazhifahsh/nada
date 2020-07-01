using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kbr : MonoBehaviour
{
    public Animator ho;

    public void hai()
    {

        ho.SetTrigger("t1");

    }
    public void hai2()
    {

        ho.SetTrigger("t2");

    }
    public void hai3()
    {

        ho.SetTrigger("t3");

    }
    public void hai4()
    {

        ho.SetTrigger("t4");

    }
    public void hai5()
    {

        ho.SetTrigger("t5");

    }
    public void hai6()
    {

        ho.SetTrigger("t6");

    }
    public void hai7()
    {

        ho.SetTrigger("t7");

    }
    public void adaaa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
