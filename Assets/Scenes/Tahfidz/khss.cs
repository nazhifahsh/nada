using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khss : MonoBehaviour
{
    public Animator sapi;
    public Animator kambing;

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
}
