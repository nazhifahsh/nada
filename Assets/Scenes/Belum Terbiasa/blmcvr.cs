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
    public void move3()
    {
        woo.SetBool("m3", true);
    }
    public void pindh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void afm1()
    {
        woo.SetBool("in2", true);
    }
    public void mo21()
    {
        woo.SetBool("221p", true);
    }
    public void mo22()
    {
        woo.SetBool("222p", true);
    }
    public void gter()
    {
        aha += 1;
    }
    void Update()
    {
        if(aha==2)
        {
            Handheld.Vibrate();
        }
    }
    public void ho()
    {
        woo.SetBool("hem", true);
    }
    public void sun()
    {
        woo.SetBool("sun", true);
    }
    public void how()
    {
        woo.SetBool("hew", true);
    }
    public void m41()
    {
        woo.SetBool("41p", true);
    }
    public void m411()
    {
        woo.SetBool("411p", true);
    }
    public void m412()
    {
        woo.SetBool("412p", true);
    }
    public void m421()
    {
        woo.SetBool("421p", true);
    }
    public void m422()
    {
        woo.SetBool("422p", true);
    }
    public void m431()
    {
        woo.SetBool("431p", true);
    }
    public void m432()
    {
        woo.SetBool("432p", true);
    }
    public void m44()
    {
        woo.SetBool("441p", true);
    }
    public void mm4()
    {
        woo.SetBool("442p", true);
    }
    public void mmm()
    {
        woo.SetBool("443p", true);
    }
    public void ngz()
    {
        woo.SetBool("nganz", true);
    }
    public void duh()
    {
        woo.SetBool("duh", true);
    }
    public void bat()
    {
        woo.SetBool("bat", true);
    }
}
