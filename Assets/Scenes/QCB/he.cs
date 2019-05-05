using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class he : MonoBehaviour
{
    public Animator bom;

    public void web()
    {
        bom.SetBool("move", true);
    }
    public void web2()
    {
        bom.SetBool("move2", true);
    }
}
