using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt : MonoBehaviour
{

    public Animator nasihat;
    bool nongol = false;
  
    public void nongoll()
    {
        nongol = true;
        nasihat.SetBool("nongol", true);
    }
}
