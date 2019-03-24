using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Animator anim;
    bool udah = false;
    public Image tampil;
  
    public void udaah()
    {
        udah = true;
        anim.SetBool("udah", true);
    }

    public void uddah()
    {
        tampil.CrossFadeAlpha(1.0f, 1.5f, false);


    }

}


