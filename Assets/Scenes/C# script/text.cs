using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Animator anim;
    bool udah = false;
    public Image tampil;
    public BoxCollider2D tiriri;

    public void udaah()
    {
        udah = true;
        anim.SetBool("udah", true);
    }
    public void udaahh()
    {
        udah = true;
        anim.SetBool("udah", true);
        scroll.instance.woi();
    }

    public IEnumerator Start()
    {
        tampil.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        


    }

    void FadeIn()
    {
       tampil.CrossFadeAlpha(1.0f, 2.5f, false);


    }

}


