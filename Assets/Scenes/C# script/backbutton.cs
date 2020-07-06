using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    public void Back()
    {
        ExampleCoroutine();
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
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
    public void fq(){
        Application.OpenURL("https://www.sekolahimpian.com/Home/Fahim%20Quran%20Plus.html");
    }
    public void df()
    {
        Application.OpenURL("https://www.sekolahimpian.com/Home/page8.html");
    }
    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1);

    }
}
