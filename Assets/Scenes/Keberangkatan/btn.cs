using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour
{
    public Animator hey;

   public void diz()
    {
        hey.SetBool("disable", true);
    }
}
