using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class things : MonoBehaviour
{
    public Animator animator;
    bool foundd = false;
  
    // Update is called once per frame

    public void ketemu()
    {
        foundd = true;
        animator.SetBool("foundd", true);
        img.score += 1;
        
    }
   
}
