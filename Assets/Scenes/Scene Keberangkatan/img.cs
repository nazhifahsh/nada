using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class img : MonoBehaviour
{
    public static img instance = null;
    public static int score = 0;
    public Animator gee;
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    
    void Update()
    {
        if (score == 9)
        {
            yo();
        }
    }
    public void yo()
    {
        gee.SetBool("bbol",true);
    }
    public void yoi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void yoa()
    {
        gee.SetBool("yes", true);
    }
}
