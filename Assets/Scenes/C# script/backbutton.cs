using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void prolog()
    {
        SceneManager.LoadScene("Prolog");
    }

    public void Keberangkatan()
    {
        SceneManager.LoadScene("Keberangkatan");
    }

    public void BelumBiasa()
    {
        SceneManager.LoadScene("Belum Terbiasa");
    }

    public void Sarapan()
    {
        SceneManager.LoadScene("Sarapan");
    }

    public void Tahfidz()
    {
        SceneManager.LoadScene("Tahfizh");
    }

    public void QCB()
    {
        SceneManager.LoadScene("qcb");
    }

    public void Diariku()
    {
        SceneManager.LoadScene("Diariq");
    }

    public void HPtime()
    {
        SceneManager.LoadScene("hptime");
    }

    public void kucingpesantren()
    {
        SceneManager.LoadScene("Kucing Pesantren");
    }

    public void TargetTurun()
    {
        SceneManager.LoadScene("targetmenurun");
    }
}
