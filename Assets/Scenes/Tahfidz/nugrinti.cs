using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nugrinti : MonoBehaviour
{
    public bool anaba, berita, selimut;
    public GameObject mip;

    public void anb()
    {
        anaba = true;
        Debug.Log("anaba:"+anaba);
    }
    public void brt()
    {
        berita = true;
        Debug.Log(berita + ":berita");
    }
    public void slmt()
    {
        selimut = true;
        selimut = false;
    }

    void Update()
    {
        if(anaba==true&& berita == true)
        {
            mip.SetActive(true);
            Debug.Log(anaba + "" + berita);
        }
    }
}
