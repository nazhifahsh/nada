﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class things : MonoBehaviour
{
    public Animator animator;
    bool foundd = false;
    public Animator animator2;
    bool yay = false;

    // Update is called once per frame
    public void ketemu()
    {
        foundd = true;
        animator.SetBool("foundd", true);
        yay = true;
        animator2.SetBool("yay", true);

    }
}