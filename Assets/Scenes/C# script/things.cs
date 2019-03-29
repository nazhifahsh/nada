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
        if (animator.enabled)
        {
            LevelControlScript.score += 1;
        }
       


    }
   
}
