using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    public Animator pulang;

    public void bck()
    {
        pulang.SetTrigger("back 0");
    }
    public void udh()
    {
        Time.timeScale = 1f;
        pulang.SetTrigger("udh 0");
    }
    public void main()
    {
        pulang.SetTrigger("main 0");
    }
    public void stopp()
    {
        Time.timeScale = 0f;
    }
}
