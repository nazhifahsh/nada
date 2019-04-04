using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour
{
   
    public Animator animator2;
    bool yay = false;
   
    // Update is called once per frame
    public void yo()
    {
        yay = true;
        animator2.SetBool("yay", true);
    }
    public void boo()
    {
        animator2.SetBool("boo", true);
    }
}
