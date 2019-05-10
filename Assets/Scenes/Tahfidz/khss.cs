using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khss : MonoBehaviour
{
    public Animator sapi;
    public Animator kambing;
    public AudioSource kutu;

    public void min()
    {
        sapi.SetBool("min", true);
    }
    public void kdp()
    {
        kambing.SetBool("mon", true);
    }
    public void kdps()
    {
        kambing.SetBool("mon", false);
    }
    public void eya()
    {
        kutu.Play();
    }
    public void ey0()
    {
        kutu.Stop();
    }
}
