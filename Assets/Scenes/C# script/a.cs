using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class a : MonoBehaviour
{
  
    public Animator aw;
    bool hehe=false,hehehe=false;

   

    public void eh()
    {
        hehe = true;
        aw.SetBool("hehe", true);
    }

    public void ehh()
    {
        hehehe = true;
        aw.SetBool("hehehe", true);
    }
   
    public void ehhh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void yow()
    {
        aw.SetBool("hehehehe", true);
    }
    public void drr()
    {
        Handheld.Vibrate();
    }
}
