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
}

