using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prolog1 : MonoBehaviour
{

    public Animator eek;
    bool p1=false, p2=false,p3=false,p4=false,geter=false,diem=false,gtr=false;

   public void wahid()
    {
        p1 = true;
        eek.SetBool("p1", true);
    }
    public void itsnain()
    {
        p2 = true;
        eek.SetBool("p2", true);
    }
    public void tsalatsa()
    {
        p3 = true;
        eek.SetBool("p3", true);
    }
    public void arbaa()
    {
        p4 = true;
        eek.SetBool("p4", true);
    }
    public void nyempil()
    {
        geter = true;
        eek.SetBool("geter", true);
    }
    public void nyempil1()
    {
        gtr = true;
        eek.SetBool("gtr", true);
    }
    public void nyempil2()
    {
        diem=true;
        eek.SetBool("diem", true);
    }
    public void drr()
    {
        Handheld.Vibrate();
    }
    public void ehhh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
