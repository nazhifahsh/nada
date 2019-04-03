using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gser : MonoBehaviour
{
    public Animator he;

    public void mov1()
    {
        he.SetBool("mo1", true);
    }
    public void mov2()
    {
        he.SetBool("mo2", true);
    }
    public void mov3()
    {
        he.SetBool("mo3", true);
    }
    public void mov4()
    {
        he.SetBool("mo4", true);
    }
    public void mov5()
    {
        he.SetBool("mo5", true);
    }
    public void mov6()
    {
        he.SetBool("mo6", true);
    }
    public void mov7()
    {
        he.SetBool("mo7", true);
    }
    public void non()
    {
        he.SetBool("non", true);
    }
    public void ila()
    {
        he.SetBool("ila", true);
    }
    public void oh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
