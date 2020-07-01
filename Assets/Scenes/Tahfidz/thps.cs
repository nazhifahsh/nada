using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thps : MonoBehaviour
{
    public Animator ayam;
    public AudioSource me;
    public static int bekotek=0;
    public static int bekotek2 = 0;
    public static int bekotek3 = 0;
    public static int bekotek4 = 0;
    public static int bekotek5 = 0;
    public static int bekotek6 = 0;
    public static int bekotek7 = 0;
    public static int bekotek8 = 0;
    public static int bekotek9 = 0;
    public static int bekotek10 = 0;
    public static int bekotek11= 0;
    public static int bekotek12= 0;
    public static int bekotek13= 0;
    public static int bekotek14= 0;
    public static bool satu, dua, tiga, empat, lima, enam, tujuh;

    public void wu()
    {
        me.Play();
    }
    public void a1()
    {
        ayam.SetBool("1", true);
    }
    public void a2()
    {
        ayam.SetBool("2", true);
    }
    public void a3()
    {
        ayam.SetBool("3", true);
    }
    public void a4()
    {
        ayam.SetBool("4", true);
    }
    public void a5()
    {
        ayam.SetBool("5", true);
    }
    public void ser2()
    {
        ayam.SetBool("ser2", true);
    }
    public void ser3()
    {
        ayam.SetBool("ser3", true);
    }
    public void ser4()
    {
        ayam.SetBool("ser4", true);
    }
    public void ser5()
    {
        ayam.SetBool("ser5", true);
    }
    public void a51()
    {
        ayam.SetBool("51", true);
    }
    public void a52()
    {
        ayam.SetBool("52", true);
    }
    public void a53()
    {
        ayam.SetBool("53", true);
    }
    public void fin()
    {
        ayam.SetBool("fin", true);
    }
    public void sec()
    {
        ayam.SetBool("sec", true);
    }
    public void nsec()
    {
        ayam.SetBool("sec", false);
    }
   public void lanjoot()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        if (bekotek == 1 &&bekotek8==1)
        {
            ayam.SetBool("aw", true);
            satu = true;
        }
        else if (bekotek2 == 1&& bekotek9==1)
        {
            ayam.SetBool("aw", true);
            dua = true;
        }
        else if (bekotek3 == 1&&bekotek10==1)
        {
            ayam.SetBool("aw", true);
            tiga = true;
        }
        else if (bekotek4 == 1&&bekotek11==1)
        {
            ayam.SetBool("aw", true);
            empat = true;
        }
        else if (bekotek5 == 1&&bekotek12==1)
        {
            ayam.SetBool("aw", true);
            lima = true;

        }
        else if (bekotek6 == 1&&bekotek13==1)
        {
            ayam.SetBool("aw", true);
            enam = true;
        }
        else if (bekotek7 == 1&&bekotek14==1)
        {
            ayam.SetBool("aw", true);
            tujuh = true;
        }
       
    }
    public void nge()
    {
        bekotek += 1;
    }
    public void nge2()
    {
        bekotek2 += 1;
    }
    public void nge3()
    {
        bekotek3 += 1;
    }
    public void nge4()
    {
        bekotek4 += 1;
    }
    public void nge5()
    {
        bekotek5 += 1;
    }
    public void nge6()
    {
        bekotek6 += 1;
    }
    public void nge7()
    {
        bekotek7 += 1;
    }
    public void nge8()
    {
        bekotek7 += 1;
    }
    public void nge9()
    {
        bekotek7 += 1;
    }
    public void nge10()
    {
        bekotek7 += 1;
    }
    public void nge11()
    {
        bekotek7 += 1;
    }
    public void nge12()
    {
        bekotek7 += 1;
    }
    public void nge13()
    {
        bekotek7 += 1;
    }
    public void nge14()
    {
        bekotek7 += 1;
    }

}
