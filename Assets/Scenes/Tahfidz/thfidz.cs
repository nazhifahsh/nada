using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thfidz : MonoBehaviour
{
    public Animator mbek;
    public Animator kwek;

    public void ng1()
    {
        mbek.SetBool("ng1", true);
    }
    public void ng2()
    {
        mbek.SetBool("ng2", true);
    }
    public void ng3()
    {
        mbek.SetBool("ng3", true);
    }
    public void ng4()
    {
        mbek.SetBool("ng4", true);
    }
    public void dng2()
    {
        mbek.SetBool("dng2", true);
    }
    public void dng21()
    {
        mbek.SetBool("dng21", true);
    }
    public void dng3()
    {
        mbek.SetBool("dng3", true);
    }
    public void dng32()
    {
        mbek.SetBool("dng32", true);
    }
    public void move()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void tps()
    {
        kwek.SetBool("tps", true);
    }
}
