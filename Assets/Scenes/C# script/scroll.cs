using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scroll : MonoBehaviour
{
    public static scroll instance = null;
    public Animator udel;
    bool booll = false;
    bool boollagi = false;
    void Start()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);


        
    }


    public void pencet()
    {
        booll= true;
        udel.SetBool("ao", true);
    }
    public void geser()
    {
        boollagi = true;
        udel.SetBool("aoo", true);
    }
    public void dut()
    {
        udel.SetBool("boollagi", true);
    }
    public void serge()
    {
        udel.SetBool("boollagi", true);
    }
    public void serr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void woi()
    {
        udel.SetTrigger("auu");
    }
    public void yy()
    {
        udel.SetBool("onklik", true);
    }
    public void gg()
    {
        udel.SetBool("onkliklg", true);
    }
    public void zrr()
    {
        udel.SetTrigger("grr");
    }
    public void hoo()
    {
        udel.SetTrigger("lll");
    }
    public void ngok()
    {
        udel.SetTrigger("haa");
    }
    public void hy()
    {
        udel.SetTrigger("hii");
    }
    public void moo()
    {
        udel.SetBool("ko",true);
    }
    public void io()
    {
        udel.SetBool("io",true);
    }
    public void move1()
    {
        udel.SetBool("to1", true);
    }
    public void move2()
    {
        udel.SetBool("to2", true);
    }
    public void move3()
    {
        udel.SetBool("to3", true);
    }
    public void move4()
    {
        udel.SetBool("to4", true);
    }
    public void move5()
    {
        udel.SetBool("to5", true);
    }
    public void txt()
    {
        udel.SetBool("too", true);
    }
    public void ttxt()
    {
        udel.SetBool("tuu", true);
    }
    public void txt0()
    {
        udel.SetBool("tooo", true);
    }
}

