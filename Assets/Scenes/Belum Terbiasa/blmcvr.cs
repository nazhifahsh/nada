using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blmcvr : MonoBehaviour
{
    public Animator woo;
    int aha = 1;

    public void onprs()
    {
        woo.SetBool("aw", true);
    }
    public void move1()
    {
        woo.SetBool("m1", true);
    }
    public void move2()
    {
        woo.SetBool("m2", true);
    }
    public void pindh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void afm1()
    {
        woo.SetBool("in2", true);
    }
    public void gter()
    {
        aha += 1;
    }
    void Update()
    {
        if (aha == 2)
        {
            Handheld.Vibrate();
        }
    }
}
