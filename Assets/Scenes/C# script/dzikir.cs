using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzikir : MonoBehaviour
{
    public Animator aaa;
    bool gelud = false;
    bool kadieu = false;
    public void woi()
    {
        gelud = true;
        aaa.SetBool("gelud", true);
        
    }

    // Update is called once per frame
    public void apan()
    {
        kadieu = true;
        aaa.SetBool("kadieu", true);
    }
}
