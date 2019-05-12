using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    public Animator pulang;

    public void bck()
    {
        pulang.SetBool("back", true);
    }
    public void udh()
    {
        Time.timeScale = 1f;
        pulang.SetBool("udh", true);
    }
    public void main()
    {
        pulang.SetBool("main", true);
    }
    public void stopp()
    {
        Time.timeScale = 0f;
    }
}
