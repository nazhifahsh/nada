using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khususon : MonoBehaviour
{
    public Animator go1;
    public Animator go2;
    public AudioSource audio;

   
    public void yopo()
    {
        go1.SetBool("yopo", true);
    }
    public void yipi()
    {
        go2.SetBool("yipi", true);
    }
    public void yipii()
    {
        go2.SetBool("yipi", false);
    }
    public void yoppo()
    {
        go1.SetBool("yoppo", true);
    }
    public void yom()
    {
        audio.Play();
    }
    public void yomm()
    {
        audio.Stop();
    }


}
