using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kucingpesantren : MonoBehaviour
{
    public Animator ayo;

    public void k1()
    {
        ayo.SetBool("k1", true);
    }
    public void k2()
    {
        ayo.SetBool("k2", true);
    }
    public void k3()
    {
        ayo.SetBool("k3", true);
    }
    public void k4()
    {
        ayo.SetBool("k4", true);
    }
    public void k5()
    {
        ayo.SetBool("k5", true);
    }
    public void k6()
    {
        ayo.SetBool("k6", true);
    }
    public void k7()
    {
        ayo.SetBool("k7", true);
    }
    public void go()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
