using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class he : MonoBehaviour
{
    public static he instance = null;
    public Animator bom;
    public AudioSource audio;
    public static int yoi = 1;
    public AudioSource audio2;

    void Start()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void web()
    {
        bom.SetBool("move", true);
    }
    public void web2()
    {
        bom.SetBool("move2", true);
    }
    public void strt()
    {
        bom.SetBool("st", true);
    }
    public void gme()
    {
        bom.SetBool("gm", true);
    }
    public void mof()
    {
        bom.SetBool("hlg", true);
    }
    public void mbeq()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void timesu()
    {
        Handheld.Vibrate();
        audio.Stop();
    }
    public void scr()
    {
        bom.SetBool("scr", true);
    }
    public void grk()
    {
        bom.SetBool("grk", true);
    }
    public void tks()
    {
        bom.SetBool("tks", true);
    }
    public void tks2()
    {
        bom.SetBool("tks2", true);
    }
    public void grk2()
    {
        bom.SetBool("grk2", true);
    }
    public void tks3()
    {
        bom.SetBool("tks3", true);
    }
    public void tks4()
    {
        bom.SetBool("tks4", true);
    }
    public void grk3()
    {
        bom.SetBool("grk3", true);
    }
    public void start()
    {
        bom.SetBool("start", true);
    }
    public void wrg()
    {
        bom.SetBool("salah", true);
    }
    public void qoq()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + yoi);
        yoi = 1;
    }
    public void main()
    {
        audio.Play();
    }
    public void main2()
    {
        audio2.Play();
    }
    public void udh()
    {
        bom.SetBool("udh", true);
    }
}
