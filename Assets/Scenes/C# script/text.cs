﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Animator anim;
    bool click = false;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click = true;
            anim.SetBool("click", true);

        }
    }

   
}