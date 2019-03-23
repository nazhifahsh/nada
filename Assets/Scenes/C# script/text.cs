using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Animator anim;
    bool udah = false;
  
    public void udaah()
    {
        udah = true;
        anim.SetBool("udah", true);
    }
   
}
