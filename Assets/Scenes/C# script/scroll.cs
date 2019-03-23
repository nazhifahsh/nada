using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public Animator udel;
    bool booll = false;
    bool boollagi = false;

    public void pencet()
    {
        booll= true;
        udel.SetBool("bool", true);
    }
    public void geser()
    {
        boollagi = true;
        udel.SetBool("boollagi", true);
    }
}
